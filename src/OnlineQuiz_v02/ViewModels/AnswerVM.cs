using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.ViewModels
{
    public class AnswerVM
    {
        public string Statement { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public QuestionVM Question { get; set; }
    }
}
