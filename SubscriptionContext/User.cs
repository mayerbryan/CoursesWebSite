using CoursesWebSite.SharedContext;

namespace CoursesWebSite.SubscriptionContext{
    public class User : Base{
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}