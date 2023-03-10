using System;
using APIAutomation.util;

namespace APIAutomation.RestSharpBase
{
    class Constants
    {
        public static String PROJECT_NAME = PropertyReader.GetPropertyValue("projectName");
        public static String REPORT_NAME = PropertyReader.GetPropertyValue("reportName");
        public static String DEVELOPER_NAME = PropertyReader.GetPropertyValue("developerName");
        public static String RESTSHARP_VERSION = PropertyReader.GetPropertyValue("restsharpVersion");
        public static String ENVIRONMENT = PropertyReader.GetPropertyValue("environment");
        public static String OPERATING_SYSTEM = PropertyReader.GetPropertyValue("operatingSystem");
        public static String EXECUTION_TYPE = PropertyReader.GetPropertyValue("executionType");
        public static Boolean IS_REPORT_SERVER_ENABLED = Boolean.Parse(PropertyReader.GetPropertyValue("isReportServerEnabled"));
        public static String REPORT_URL = PropertyReader.GetPropertyValue("reportUrl");
        public static String REPORT_THEME = PropertyReader.GetPropertyValue("reportTheme");
        public static String BASE_URL = PropertyReader.GetPropertyValue("baseUrl");
        public static String USERNAME_CREATE = PropertyReader.GetPropertyValue("username_create");
        public static String JOBTITLE_CREATE = PropertyReader.GetPropertyValue("jobtitle_create");
        public static String USERNAME_UPDATE = PropertyReader.GetPropertyValue("username_update");
        public static String JOBTITLE_UPDATE = PropertyReader.GetPropertyValue("jobtitle_update");
        public static String USERNAME_PATCH = PropertyReader.GetPropertyValue("username_patch");
        public static String JOBTITLE_PATCH = PropertyReader.GetPropertyValue("jobtitle_patch");
        public static String USER_ID = PropertyReader.GetPropertyValue("user_id");
        public static String FIRSTNAME = PropertyReader.GetPropertyValue("firstname");
        public static String LASTNAME = PropertyReader.GetPropertyValue("lastname");


    }
}