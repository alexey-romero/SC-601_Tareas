using AP.Data.Data;
using AP.Data.Models;
using AP.Data.Interfaces;


namespace AP.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
