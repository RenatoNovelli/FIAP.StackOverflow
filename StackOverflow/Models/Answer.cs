namespace StackOverflow.API.Models
{
    public class Answer
    {
        public int Id
        {
            get;
            set;
        }

        public string AuthorId
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int Votes
        {
            get;
            set;
        }

        public int QuestionId
        {
            get;
            set;
        }
    }
}
