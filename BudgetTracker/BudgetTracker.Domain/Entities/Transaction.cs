using BudgetTracker.Domain.Enums;

namespace BudgetTracker.Domain;

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; private set; }
    public TransactionType Type { get; set; }
    public int? CategoryId { get; set; }
    public DateOnly TransactionDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Category? Category { get; set; }
}









/*if (amount <= 0)
{
    throw ArgumentOutOfRangeException(
        nameof(Amount),
        "Amount must be greater than zero.");
    
}*/