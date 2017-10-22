using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.Models
{
    public class QuestionM
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public ICollection<AnswerM> Answers { get; set; }
    }
}
