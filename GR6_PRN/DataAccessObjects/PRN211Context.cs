using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using BusinessObejcts;
#nullable disable

namespace BusinessObejcts
{
    public partial class PRN211Context : DbContext
    {
        public PRN211Context()
        {
        }

        public PRN211Context(DbContextOptions<PRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseMentorSlot> CourseMentorSlots { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<MentorRating> MentorRatings { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestQuestion> TestQuestions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }
        public virtual DbSet<UserSlot> UserSlots { get; set; }
        public virtual DbSet<UserTest> UserTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HP2DTMU\\MSSQLSERVER01; Database=PRN211; Uid=sa; Pwd=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<CourseMentorSlot>(entity =>
            {
                entity.ToTable("course_mentor_slots");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.MentorId).HasColumnName("mentorId");

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseMentorSlots)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__course_me__cours__5EBF139D");

                entity.HasOne(d => d.Mentor)
                    .WithMany(p => p.CourseMentorSlots)
                    .HasForeignKey(d => d.MentorId)
                    .HasConstraintName("FK__course_me__mento__5FB337D6");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.CourseMentorSlots)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__course_me__slotI__60A75C0F");
            });

            modelBuilder.Entity<Mentor>(entity =>
            {
                entity.ToTable("mentors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvailableSlots).HasColumnName("available_slots");

                entity.Property(e => e.Specialty)
                    .HasMaxLength(255)
                    .HasColumnName("specialty");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Mentors)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__mentors__userId__5070F446");
            });

            modelBuilder.Entity<MentorRating>(entity =>
            {
                entity.ToTable("mentor_ratings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(1000)
                    .HasColumnName("feedback");

                entity.Property(e => e.MentorId).HasColumnName("mentorId");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Mentor)
                    .WithMany(p => p.MentorRatingMentors)
                    .HasForeignKey(d => d.MentorId)
                    .HasConstraintName("FK__mentor_ra__mento__5812160E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MentorRatingUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__mentor_ra__userI__571DF1D5");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasColumnName("content");

                entity.Property(e => e.PostDate)
                    .HasColumnType("date")
                    .HasColumnName("post_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.UserId)

                    .HasName("PK__profiles__CB9A1CFF5A6CF0E3")

                    .HasName("PK__profiles__CB9A1CFF5B4D3667");


                entity.ToTable("profiles");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.RegDate)
                    .HasColumnType("date")
                    .HasColumnName("reg_date");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Profile)
                    .HasForeignKey<Profile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__profiles__userId__403A8C7D");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("questions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("answer");

                entity.Property(e => e.OptA)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optA");

                entity.Property(e => e.OptB)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optB");

                entity.Property(e => e.OptC)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optC");

                entity.Property(e => e.OptD)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("optD");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("registrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__registrat__slotI__5441852A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__registrat__userI__534D60F1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("slots");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("tests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TestQuestion>(entity =>
            {
                entity.ToTable("test_questions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.QuestionId).HasColumnName("questionId");

                entity.Property(e => e.TestId).HasColumnName("testId");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TestQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__test_ques__quest__44FF419A");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestQuestions)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK__test_ques__testI__45F365D3");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__users__roleId__398D8EEE");
            });

            modelBuilder.Entity<UserCourse>(entity =>
            {
                entity.ToTable("user_courses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__user_cour__cours__6477ECF3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_cour__userI__6383C8BA");
            });

            modelBuilder.Entity<UserSlot>(entity =>
            {
                entity.ToTable("user_slots");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.UserSlots)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__user_slot__slotI__4D94879B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSlots)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_slot__userI__4CA06362");
            });

            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.ToTable("user_tests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.TestId).HasColumnName("testId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.UserTests)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK__user_test__testI__49C3F6B7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_test__userI__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
