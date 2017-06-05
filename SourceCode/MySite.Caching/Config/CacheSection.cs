using System.Configuration;

namespace MySite.Caching.Config
{
    /// <summary>
    /// 缓存
    /// </summary>
    public class CacheSection : ConfigurationSection
    {
        /// <summary>
        /// Gets the providers.
        /// </summary>
        [ConfigurationProperty("providers", IsRequired = true)]
        public CacheProviderCollection Providers
        {
            get
            {
                CacheProviderCollection providers = (CacheProviderCollection)base["providers"];
                return providers;
            }
        }
    }
}
