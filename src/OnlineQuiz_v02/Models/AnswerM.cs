namespace OnlineQuiz_v02.Models
{
    public class AnswerM
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public QuestionM Question { get; set; }
    }
}