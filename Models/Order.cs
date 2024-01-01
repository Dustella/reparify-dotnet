public class Order
{
    public int Id { get; set; }
    public required string CustomerName { get; set; }
    public required string CustomerQQ { get; set; }

    public string? CustomerPhone { get; set; }

    public string? Detail { get; set; }

    public string? Address { get; set; }

    public FaultType FaultType { get; set; }

    public TaskStatus Status { get; set; }

    public User? AssignedTo { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}


public enum TaskStatus
{
    Unassigned,
    Assigned,
    Processing,
    Finished,
}
public enum FaultType
{
    Hardware,
    Software,
    Other
}