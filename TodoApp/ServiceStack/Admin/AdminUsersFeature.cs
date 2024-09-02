
namespace ServiceStack.Admin
{
    internal class AdminUsersFeature : IPlugin
    {
        public object QueryUserAuthProperties { get; set; }
        public object QueryMediaRules { get; set; }
        public object FormLayout { get; set; }
    }
}