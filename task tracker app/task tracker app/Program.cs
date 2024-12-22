internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        while (true)
        {
            Console.Write("Choose an option:\n");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. Update an existing task");
            Console.WriteLine("3. Delete a task");
            Console.WriteLine("4. Lits all tasks");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter task description");
                    break;
                default:
                    Console.WriteLine("Invalid option. Select a valid option:");
                    break;
            }
        }
    }
}

public class Task
{

    public int TaskId { get; set; }
    public string TaskDescription { get; set; }
    public string TaskStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public void AddTask(string description)
    {

    }
}

public class TaskManager
{
    private List<Task> tasks = new List<Task>();
}


