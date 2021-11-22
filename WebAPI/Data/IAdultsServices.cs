using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Model;


namespace WebApi.Data
{
    public interface IAdultsServices
    {
        Task<Adult> AddAdultsAsync(Adult adult);
        //Task<IList<Family>> GetFamiliesAsync();
        Task<IList<Adult>> GetAdultsAsync();
        Task RemoveAdultsAsync(int Id);
    }
}