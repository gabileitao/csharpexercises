using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostStackOverflow {
    internal class Post {

        public string Title;
        public string Description;
        public DateTime Datetime;

        public Post(string title, string description, DateTime dateTime){
            Title = title;
            Description = description;
            Datetime = dateTime;
        }

        public int VoteUp(bool vote) {
            int upAdd = 0;

            if (vote) { upAdd++; }

            return upAdd;
        }

        public int VoteDown(bool vote) {
            int downAdd = 0;

            if (!vote) { downAdd++; }

            return downAdd;
        }

    }
}
