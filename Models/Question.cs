using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string q { get; set; }
        public string a { get; set; }
        public string wa1 { get; set; }
        public string wa2 { get; set; }
        
        public Question()
        {

        }
    }
}
