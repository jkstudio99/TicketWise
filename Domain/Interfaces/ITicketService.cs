using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Entities;

namespace Domain.Interfaces;

public interface ITicketService
{
    List<GetTicketResponse> GetTickets(GetTicketRequest request);
    GetTicketResponse FindTicket(int ticketId);
}