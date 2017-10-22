using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.ViewModels
{
    public class QuestionVM
    {
        [Required]
        public string Statement { get; set; }
        public ICollection<AnswerVM> Answers { get; set; }
    }
}
