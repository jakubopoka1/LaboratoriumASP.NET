using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać imię!")]
    [MaxLength(length:20, ErrorMessage = "Imię nie może być dłuższe niż 20 znaków")]
    [MinLength(length:2, ErrorMessage = "Imię musi mieć conajmniej 2 znaki!")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać nazwisko!")]
    [MaxLength(length:50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków")]
    [MinLength(length:2, ErrorMessage = "Nazwisko musi mieć conajmniej 2 znaki!")]
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Phone]
    [RegularExpression("\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wpisz numer wg wzoru: XXX XXX XXX")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    public DateOnly BirthDate { get; set; }
    
}