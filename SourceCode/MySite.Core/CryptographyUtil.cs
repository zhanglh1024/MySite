﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Core
{
    /// <summary>
    /// 加解密相关类
    /// </summary>
    public static class CryptographyUtil
    {
        #region AES加解密
        private const string ServerAuthTokenKey = "mywebsite-server"; //加密服务端AuthToken
        private static readonly byte[] ServerAuthTokenIv = { 0x32, 0x31, 0x34, 0x38, 0x37, 0x36, 0x35, 0x32, 0x38, 0x31, 0x37, 0x34, 0x36, 0x33, 0x35, 0x33 };

        private const string ClientAuthTokenKey = "mywebsite-client";//加密客户端AuthToken
        private static readonly byte[] ClientAuthTokenIv = { 0x38, 0x31, 0x37, 0x34, 0x36, 0x33, 0x35, 0x33, 0x32, 0x31, 0x34, 0x38, 0x37, 0x36, 0x35, 0x32 };

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="toEncrypt">明文</param>
        /// <param name="key">秘钥</param>
        /// <param name="ivBytes">向量</param>
        /// <returns>密文</returns>
        public static string AESEncrypt(string toEncrypt, string key, byte[] ivBytes)
        {
            byte[] toEncryptBytes = System.Text.Encoding.UTF8.GetBytes(toEncrypt);
            var rijndael = new RijndaelManaged();
            rijndael.Key = System.Text.Encoding.UTF8.GetBytes(key);
            rijndael.IV = ivBytes;
            ICryptoTransform cryptoTransform = rijndael.CreateEncryptor();
            byte[] resultBytes = cryptoTransform.TransformFinalBlock(toEncryptBytes, 0, toEncryptBytes.Length);
            return Convert.ToBase64String(resultBytes);
        }

        /// <summary>
        /// 服务端加密
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <returns></returns>
        public static string AESEncryServer(string toEncrypt)
        {
            return AESEncrypt(toEncrypt, ServerAuthTokenKey, ServerAuthTokenIv);
        }

        /// <summary>
        /// 客户端加密
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <returns></returns>
        public static string AESEncryClient(string toEncrypt)
        {
            return AESEncrypt(toEncrypt, ClientAuthTokenKey, ClientAuthTokenIv);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="toDecrypt">密文</param>
        /// <param name="key">秘钥</param>
        /// <param name="ivBytes">向量</param>
        /// <returns>明文</returns>
        private static string AESDecrypt(string toDecrypt, string key, byte[] ivBytes)
        {
            byte[] toDecryptBytes = Convert.FromBase64String(toDecrypt);
            var rijndael = new RijndaelManaged();
            rijndael.Key = Encoding.UTF8.GetBytes(key);
            rijndael.IV = ivBytes;
            ICryptoTransform cryptoTransform = rijndael.CreateDecryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(toDecryptBytes, 0, toDecryptBytes.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// 解密客户端密文
        /// </summary>
        /// <param name="toDecrypt"></param>
        /// <returns></returns>
        public static string AESDecryptClient(string toDecrypt)
        {
            return AESDecrypt(toDecrypt, ClientAuthTokenKey, ClientAuthTokenIv);
        }

        /// <summary>
        /// 解密服务端密文
        /// </summary>
        /// <param name="toDecrypt"></param>
        /// <returns></returns>
        public static string AESDecryptServer(string toDecrypt)
        {
            return AESDecrypt(toDecrypt, ServerAuthTokenKey, ServerAuthTokenIv);
        }

        #endregion

        #region MD5加密

        /// <summary>
        /// MD5加密[大写]
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <returns></returns>
        public static string Md5Hash(string toEncrypt)
        {
            using (var md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                var sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                foreach (byte b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }
                // Return the hexadecimal string.
                return sBuilder.ToString().ToUpper();
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <returns></returns>
        public static string Md5NormalHash(string toEncrypt)
        {
            using (var md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                var sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                foreach (byte b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }
                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        #endregion

    }
}
