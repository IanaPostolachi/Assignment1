using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Model;


namespace Assignment.Data
{
    public interface IFileContext
    {
        Task<Adult> AddAdultsAsync(Adult adult);
        //Task<IList<Family>> GetFamiliesAsync();
        Task<IList<Adult>> GetAdultsAsync();
        Task RevomeAdultsAsync(int Id);
    }
}