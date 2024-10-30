using Domain.DTOs.Request;
using Domain.Entities;

namespace Domain.Repository;

public interface ITicketRepository : IGegenericRepository<Ticket>
{
    List<Ticket> GetTickets(GetTicketRequest request);
}