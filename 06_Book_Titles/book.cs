using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Book_Titles
{
    
    class Book
    {


        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                string[] n = value.Split(' ');
                string NewString = "";
                char[] a = value.ToLower().ToCharArray();
                bool first = true;
                string[] SkipList = { "a", "an", "and", "over", "the", "in", "of" };


                foreach (string element in n)
                {
                    if (!first)
                        NewString += " ";

                    if (first || !SkipList.Contains(element))
                    {
                        NewString += char.ToUpper(element[0]) + element.Substring(1);
                    }


                    else
                    {
                        NewString += element;
                    }

                    first = false;
                    

                }
                this.title = NewString;
            }
        }
    }
}

