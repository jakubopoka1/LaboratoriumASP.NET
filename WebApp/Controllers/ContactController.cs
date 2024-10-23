using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "john.smith@gmail.com",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(1985, 9, 9),
            }
        },
        {
            2, new ContactModel()
            {
                Id = 2,
                FirstName = "Jack",
                LastName = "Kowalski",
                Email = "jack.kowalski@gmail.com",
                PhoneNumber = "123 456 789",
                BirthDate = new DateOnly(1975, 10, 10),
            }
        },
        {
            3, new ContactModel()
            {
                Id = 3,
                FirstName = "Kuba",
                LastName = "Nowak",
                Email = "kuba.nowak@gmail.com",
                PhoneNumber = "666 666 666",
                BirthDate = new DateOnly(1977, 5, 15),
            }
        }
        
    };

    private static int _currentId = 3;
    
    // Lista kontaktów
    public IActionResult Index()
    {
        return View(_contacts);
    }

    // Zwraca formularz dodania kontaktu
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    
    // Odebranie danych z formularzu, zapisanie kontaktu i powrót do listy kontaktów
    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        // dodanie kontaktu
        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);
        return View("Index", _contacts);
    }

    public IActionResult Delete(int id)
    {
        _contacts.Remove(id);
        return View("Index", _contacts);
    }

    public IActionResult Details(int id)
    {
        return View(_contacts[id]);
    }
}