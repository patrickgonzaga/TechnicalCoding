using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality.TechnicalCodeFunctionality
{

    public class Authors
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }

        public Authors (int authorId, string authorName, string authorEmail)
        {
            AuthorID = authorId;
            AuthorName = authorName;    
            AuthorEmail = authorEmail;
        }

    }

    public class Books : IEnumerable
    { 
        private Authors[] AuthorArray = new Authors[4];
        public Books()
        {
            AuthorArray[0] = new Authors(1, "Pat", "Pat.Com");
            AuthorArray[1] = new Authors(2, "Tap", "Tap.Com");
            AuthorArray[2] = new Authors(3, "Pet", "Pet.Com");
            AuthorArray[3] = new Authors(4, "Pit", "Pit.Com");
        }

        public IEnumerator GetEnumerator()
        {
            return AuthorArray.GetEnumerator();
        }

    }



}

