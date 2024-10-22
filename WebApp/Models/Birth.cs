namespace WebApp.Models;

public class Birth
{
    public string? Name { get; set; }
    
    public DateTime? BirthDate { get; set; }

    public bool IsValid()
    {
        return Name != null && BirthDate != null;
    }

    public int CalculateAge()
    {
        if (BirthDate == null)
        {
            throw new InvalidOperationException("BirthDate cannot be null.");
        }
        
        DateTime today = DateTime.Now;
        int age = today.Year - BirthDate.Value.Year;
        
        if (BirthDate.Value.Date > today.AddYears(-age)) throw new InvalidOperationException("BirthDate cannot be greater than today year.");
        
        return age;
    }
}