using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Domain.Entities.Enums;

namespace WebApplication1.Domain
{
     class User
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }

          [Required]
          [Display(Name = "Username")]
          [StringLength(30, MinimumLength = 4, ErrorMessage = "Username must be less than 30 Characters")]
          public string Username { get; set; }

          [Required]
          [Display(Name = "Password")]
          [StringLength(40, MinimumLength = 4, ErrorMessage = "Password must be more than 8 characters")]
          public string Password { get; set; }

          [Required]
          [EmailAddress]
          [Display(Name = "Email Address")]
          [StringLength(30)]
          public string Email { get; set; }

          public URole Level { get; set; }

          [StringLength(100)]
          public string AvatarUrl { get; set; }

          [DataType(DataType.Date)]
          public DateTime RegisterDate { get; set; }
     }
}