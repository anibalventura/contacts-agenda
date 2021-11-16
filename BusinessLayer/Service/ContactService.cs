using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class ContactService : IService<Contact>
    {
        private ContactRepository contactRepository;

        public ContactService(SqlConnection connection)
        {
            contactRepository = new ContactRepository(connection);
        }

        public bool Add(Contact contact)
        {
            return contactRepository.Add(contact);
        }

        public bool Edit(Contact contact)
        {
            return contactRepository.Edit(contact);
        }

        public bool Delete(int id)
        {
            return contactRepository.Delete(id);
        }

        public Contact GetById(int id)
        {
            return contactRepository.GetById(id);
        }

        public DataTable GetAll(int idUser)
        {
            return contactRepository.GetAll(idUser);
        }
    }
}
