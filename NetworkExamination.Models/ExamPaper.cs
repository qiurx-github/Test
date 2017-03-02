using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkExamination.Models
{
    public class ExamPaper
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public decimal Score { get; set; }
        public Dictionary<int, char> AnswerCard { get; set; }
        public string Content { get; set; }
        public int MyProperty { get; set; }
    }
}
