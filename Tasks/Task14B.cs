using System.ComponentModel.DataAnnotations;

namespace Tasks;


public class Task14B
{
    //Task14B means Employee
    [Required]
    private string? Name{set;get;}
    private string? PetName{set;get;}
    private DateTime? JoiningDate { set; get; }

    public void DisplayEmployeeDetails()
    {
      Console.WriteLine($"Name: {Name??"No Name Provided"}");
      Console.WriteLine($"PetName: {PetName??"No Pet Provided"}");
      Console.WriteLine($"Joining Date: {JoiningDate?.ToShortDateString() ?? "Joining date not available"}");
    }

    static void Main(string[] args)
    {
        List<Task14B> tasks = new()
        {
           new Task14B{Name="John",PetName="Jummy",JoiningDate=new DateTime(1994, 7, 15) },
           new Task14B{Name="A",JoiningDate=new DateTime(1994, 9, 17)},
           new Task14B{Name="B",PetName="Nikki"},
        };
        foreach (var task in tasks)
        {
            task.DisplayEmployeeDetails();
        }
    }
}