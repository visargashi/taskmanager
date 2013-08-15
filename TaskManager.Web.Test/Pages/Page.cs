namespace TaskManager.Web.Test.Pages
{
    public abstract class Page
    {
        protected Page()
        {
            BaseUrl = "http://localhost/TaskManager/";
        }

        /// <summary>
        ///     Page title
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        ///     Page url
        /// </summary>
        public abstract string Url { get; }

        /// <summary>
        ///     Base URL
        /// </summary>
        protected string BaseUrl { get; private set; }

        /// <summary>
        ///     Go to page
        /// </summary>
        public virtual void Goto()
        {
            Browser.Goto(Url);
        }

        /// <summary>
        ///     Returns true if browser is at the page
        /// </summary>
        /// <returns></returns>
        public virtual bool IsAt()
        {
            return Browser.Title == Title;
        }
    }
}