//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AskMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Answers = new HashSet<Answer>();
            this.Questions = new HashSet<Question>();
        }

        public int UserId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "This field is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Passowrd")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required.")]
        [MinLength(6, ErrorMessage = "Password must be of minimum 6 length.")]
        public string UserPassword { get; set; }

        [DisplayName("Confirm Passowrd")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required.")]
        [Compare("UserPassword")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Intro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}