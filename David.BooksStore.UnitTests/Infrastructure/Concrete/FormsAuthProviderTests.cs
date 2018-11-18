using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace David.BooksStore.WebApp.Infrastructure.Concrete.Tests
{
    [TestClass()]
    public class FormsAuthProviderTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            string inputPwdHash = FormsAuthProvider.HashMD5("pwd");
            Debug.WriteLine("\n\n************************CompletedTest***************************\n\n");
            Debug.WriteLine(inputPwdHash);
            Debug.WriteLine("\n\n*************************CompletedTest**************************\n\n");
        }
    }
}