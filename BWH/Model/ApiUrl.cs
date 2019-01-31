namespace BandwagonHelper
{
    public static class ApiUrl
    {
        public static string SERVICE_INFO = "getServiceInfo";
        public static string LIVE_SERVICE_INFO = "getLiveServiceInfo";
        
        public static string START = "start";
        public static string STOP = "stop";
        public static string RESTART = "restart";
        public static string KILL = "kill";

        public static string AVAILABLE_OS = "getAvailableOS";
        public static string REINSTALL_OS = "reinstallOS";

        public static string RESET_ROOT_PASSWORD = "resetRootPassword";

        public static string RAW_USAGE_STATS = "getRawUsageStats";

        public static string SNAPSHOT_LIST = "snapshot/list";
        public static string SNAPSHOT_CREATE = "snapshot/create";
        public static string SNAPSHOT_DELETE = "snapshot/delete";
        public static string SNAPSHOT_RESTORE = "snapshot/restore";
    }
}
