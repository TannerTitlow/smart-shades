using SmartShades.Debugging;

namespace SmartShades
{
    public class SmartShadesConsts
    {
        public const string LocalizationSourceName = "SmartShades";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d23623f0eb664284a38adf622e2af560";
    }
}
