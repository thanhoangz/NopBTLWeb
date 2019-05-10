namespace MinhHieuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MinhHieuShopContext dbContext;

        public MinhHieuShopContext Init()
        {
            return dbContext ?? (dbContext = new MinhHieuShopContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}