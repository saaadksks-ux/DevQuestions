using System.Net;

namespace DevQuestion.Domain.Reports;

public class Reports
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ReportedUserId { get; set; }
    public Guid? ResolvedByUserId { get; set; }
    public required string Reason { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}