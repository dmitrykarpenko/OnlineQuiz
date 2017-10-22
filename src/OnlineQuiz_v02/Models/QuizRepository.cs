using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.Models
{
    public class QuizRepository : IQuizRepository
    {
        private QuizContext _context;

        public QuizRepository(QuizContext context)
        {
            _context = context;
        }

        public IEnumerable<QuestionM> GetAllQuestions(bool includeAnswers = false)
        {
            var questionsDbSet = _context.Questions;
            var ret = includeAnswers ? questionsDbSet.Include(q => q.Answers).ToList()
                                     : questionsDbSet.ToList();
            return ret;
        }
    }
}
