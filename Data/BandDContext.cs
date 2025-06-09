//using System.Collections.Generic;
//using System.Reflection.Emit;
//using Core.Models;
//using Microsoft.EntityFrameworkCore;
//namespace Data
//{
//    public class BandDContext : DbContext
//    {
//        public BandDContext(DbContextOptions<BandDContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<User> Users { get; set; }
//        public DbSet<Question> Questions { get; set; }
//        public DbSet<Answer> Answers { get; set; }
//        public DbSet<AnswerDB> AnswersDB { get; set; }


//    }
//}

using System.Collections.Generic;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BandDContext : DbContext
    {
        public BandDContext(DbContextOptions<BandDContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerDB> AnswersDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // קשר בין Question ל-User (Cascade)
            modelBuilder.Entity<Question>()
                .HasOne(q => q.User)
                .WithMany(u => u.Questions)
                .HasForeignKey(q => q.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // קשר בין Answer ל-User (ללא Cascade כדי למנוע שגיאה)
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.User)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // קשר בין Answer ל-Question (Cascade מותר)
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany()
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // קשר בין Question ל-AnswerDB (Nullable)
            modelBuilder.Entity<Question>()
                .HasOne(q => q.AnswerDB)
                .WithMany()
                .HasForeignKey(q => q.AnswerDBId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}



