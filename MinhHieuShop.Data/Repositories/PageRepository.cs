using MinhHieuShop.Data.Infrastructure;
using MinhHieuShop.Model.Models;

namespace MinhHieuShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}