using System.Collections.Generic;

namespace OnlineQuiz_v02.Models
{
    public interface IQuizRepository
    {
        IEnumerable<QuestionM> GetAllQuestions(bool includeAnswers = false);
    }
}