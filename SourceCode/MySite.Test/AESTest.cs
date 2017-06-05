using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySite.Core;

namespace MySite.Test
{
    [TestClass]
    public class AESTest
    {
        /// <summary>
        /// 加密分析
        /// </summary>
        [TestMethod]
        public void AES_Encry_Test()
        {
            var str = "aaaaa";
            var strCry = CryptographyUtil.AESEncryServer(str);
            Console.WriteLine(strCry);
        }

        /// <summary>
        /// 解密分析
        /// </summary>
        [TestMethod]
        public void AES_Decrp_Test()
        {
            var str = "bbbbb";
            var strCry = CryptographyUtil.AESDecryptServer(str);
            Console.WriteLine(strCry);
        }
    }
}
