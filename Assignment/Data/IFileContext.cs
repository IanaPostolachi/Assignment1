using System.Collections.Generic;
using Assignment.Model;


namespace Assignment.Data
{
    public interface IFileContext
    {
        void AddAdults(Adult adult);
        IList<Family> GetFamilies();
        IList<Adult> GetAdults();
        void RevomeAdults(int Id);
    }
}