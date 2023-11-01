using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class User
    {
        public User()
        {
            MentorRatingMentors = new HashSet<MentorRating>();
            MentorRatingUsers = new HashSet<MentorRating>();
            Mentors = new HashSet<Mentor>();
            Registrations = new HashSet<Registration>();
            UserSlots = new HashSet<UserSlot>();
            UserTests = new HashSet<UserTest>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<MentorRating> MentorRatingMentors { get; set; }
        public virtual ICollection<MentorRating> MentorRatingUsers { get; set; }
        public virtual ICollection<Mentor> Mentors { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<UserSlot> UserSlots { get; set; }
        public virtual ICollection<UserTest> UserTests { get; set; }
    }
}
