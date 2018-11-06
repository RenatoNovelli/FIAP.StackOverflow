using System.Collections.Generic;

namespace StackOverflow.API.Models
{
    public class Question
    {
        public Question()
        {
            Tags = new List<string>();
        }

        public int Id
        {
            get;
            set;
        }

        public int AuthorId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public List<string> Tags
        {
            get;
            set;
        }
    }
}
