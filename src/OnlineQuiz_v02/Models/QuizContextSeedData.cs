using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.Models
{
    public class QuizContextSeedData
    {
        private QuizContext _context;

        public QuizContextSeedData(QuizContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Questions.Any())
            {
                #region questions (with answers)
                var questions = new List<QuestionM>()
                {
                    new QuestionM()
                    {
                        Statement = "What does Marsellus Wallace look like?",
                        Answers = new List<AnswerM>()
                        {
                            new AnswerM() {
                                Statement = "Does he look like a bitch?",
                                IsCorrect = false
                            },
                            new AnswerM() {
                                Statement = "H-H-He's black...",
                                IsCorrect = true
                            }
                        }
                    },
                    new QuestionM()
                    {
                        Statement = "English, motherfucker! Do you speak it!?",
                        Answers = new List<AnswerM>()
                        {
                            new AnswerM() {
                                Statement = "Yes!!",
                                IsCorrect = true
                            },
                            new AnswerM() {
                                Statement = "No",
                                IsCorrect = false
                            }
                        }
                    }
                };
                #endregion

                _context.Questions.AddRange(questions);
                _context.Answers.AddRange(questions.SelectMany(q => q.Answers));

                await _context.SaveChangesAsync();
            }
        }
    }
}
