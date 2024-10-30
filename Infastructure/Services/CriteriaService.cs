using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;

namespace Infrastructure.Services;

public class CriteriaService : ICriteriaService
{
    private readonly IUnitOfWork unitOfWork;
    public CriteriaService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    public List<Category> GetCategories()
    {
        return unitOfWork.Repository<Category>().ListAll();
    }

    public List<Product> GetProducts()
    {
        return unitOfWork.Repository<Product>().ListAll();
    }

    public List<Priority> GetPriorities()
    {
        return unitOfWork.Repository<Priority>().ListAll();
    }

    public List<string> GetStatus()
    {
        return new List<string>
        {
            "NEW",
            "OPEN",
            "CLOSED"
        };
    }
}