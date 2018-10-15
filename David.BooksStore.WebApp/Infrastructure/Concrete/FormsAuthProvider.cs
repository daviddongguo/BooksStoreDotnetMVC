using David.BooksStore.Domain.Concrete;
using David.BooksStore.WebApp.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;

namespace David.BooksStore.WebApp.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public EFDbContext Db { get; set; }

        public static string HashMD5(string text)
        {
            var source = Encoding.UTF8.GetBytes(text);

            using(MD5 hasher = MD5.Create())
            {
                var result = hasher.ComputeHash(source);

                return Convert.ToBase64String(result);
            }
        }

        public bool Authenticate(string username, string password)
        {
            bool result = false;

            var user = Db.Users.FirstOrDefault(i => i.Username == username);

            if (user != null)
            {
                var inputPwdHash = HashMD5(password);

                if(user.PasswordHash == inputPwdHash)
                {
                    result = true;
                }
            }

            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }

            return result;
        }
    }
}