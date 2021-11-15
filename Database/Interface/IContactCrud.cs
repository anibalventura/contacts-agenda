using Database.Model;
using System.Data;

namespace Database.Repository
{
    public interface IContactCrud
    {
        bool Add(Contact user);
        bool Delete(int id);
        bool Edit(Contact user);
        DataTable GetAll(int idUser);
        Contact GetById(int id);
    }
}