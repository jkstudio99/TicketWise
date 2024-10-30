namespace Domain.DTOs.Request;

public class GetTicketRequest
{
    public string? summary { get; set; }
    public int[]? ProductId { get; set; }
    public int[]? CategoryId { get; set; }
    public int[]? PriorityId { get; set; }
    public string[]? Status { get; set; }
    public string[]? RaisedBy { get; set; }
}