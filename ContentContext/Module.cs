

using CoursesWebSite.SharedContext;

namespace CoursesWebSite.ContentContext
{
    public class Module : Base
    {

        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }
}