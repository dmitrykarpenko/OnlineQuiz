using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.Models
{
    public class QuizContext : DbContext
    {
        private IConfigurationRoot _config;
        private DbContextOptions _options;

        public QuizContext(IConfigurationRoot config, DbContextOptions options)
            : base(options)
        {
            _config = config;
            _options = options;
        }

        public DbSet<QuestionM> Questions { get; set; }
        public DbSet<AnswerM> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:QuizContextConnection"]);
        }
    }
}
