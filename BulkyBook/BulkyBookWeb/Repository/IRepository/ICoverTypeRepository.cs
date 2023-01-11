using BulkyBookWeb.Models;

namespace BulkyBookWeb.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType obj);
    }
}
