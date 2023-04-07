using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiso_Learning_App
{
    public class Wiso_Q
    {
        public int Id { get; set; }
        public bool IsMultipleChoice { get; set; }
        public string QuestionHeader { get; set; }
        public string Question { get; set; }
        public string AnswerHeader { get; set; }
        public string[] Answers { get; set; }
        public int Choices { get; set; }
    }
}
