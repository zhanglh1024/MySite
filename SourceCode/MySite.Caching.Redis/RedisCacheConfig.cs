using System;
using System.Configuration;

namespace MySite.Caching.Redis
{
    /// <summary>
    /// The redis cache config.
    /// </summary>
    public static class RedisCacheConfig
    {
        /// <summary>
        /// The config.
        /// </summary>
        public static readonly string Config = ConfigurationManager.AppSettings["RedisCacheConfig"];

        /// <summary>
        /// The db index.
        /// </summary>
        public static readonly int DbIndex = Convert.ToInt32(ConfigurationManager.AppSettings["RedisCacheDb"] ?? "0");
    }
}
