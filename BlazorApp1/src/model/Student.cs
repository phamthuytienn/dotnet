using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data;

public class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid Date of Birth.")]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Batch Time is required.")]
    public string BatchTime { get; set; }

    [Required(ErrorMessage = "Phone Number is required.")]
    [Phone(ErrorMessage = "Invalid Phone Number.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Email Address is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string EmailAddress { get; set; }

    [Url(ErrorMessage = "Invalid Website URL.")]
    public string WebsiteUrl { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    // Other properties and relationships
}