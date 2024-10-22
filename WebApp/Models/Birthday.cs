namespace WebApp.Models;

public class Birthday
{
    public string? Name { get; set; }
    
    public DateTime? Date { get; set; }

    public bool IsValid()
    {
        return Name != null && Date != null;
    }

    public int Birth()
    {
        if (Date == null)
        {
            throw new InvalidOperationException("Date cannot be null.");
        }
        
        DateTime today = DateTime.Now;
        int age = today.Year - Date.Value.Year;
        
        if (Date.Value.Date > today.AddYears(-age)) throw new InvalidOperationException("Date cannot be greater than today year.");
        
        return age;
    }
}