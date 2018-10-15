using Microsoft.VisualStudio.TestTools.UnitTesting;
using David.BooksStore.WebApp.Infrastructure.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using David.BooksStore.WebApp.Infrastructure.Abstract;
using System.Diagnostics;

namespace David.BooksStore.WebApp.Infrastructure.Concrete.Tests
{
    [TestClass()]
    public class FormsAuthProviderTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            string inputPwdHash = FormsAuthProvider.HashMD5("admin");
            Debug.WriteLine("\n\n************************CompletedTest***************************\n\n");
            Debug.WriteLine(inputPwdHash);
            Debug.WriteLine("\n\n*************************CompletedTest**************************\n\n");
        }
    }
}