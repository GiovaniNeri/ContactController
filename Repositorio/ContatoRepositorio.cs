using ContactController.DBContext;

namespace ContactController.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly ContactContext _contactContext;
        public ContatoRepositorio(ContactContext contactContext) 
        {
            _contactContext = contactContext;
        }
        public Contact Adicionar(Contact contact)
        {
            _contactContext.Contacts.Add(contact);
            _contactContext.SaveChanges();
            return contact;
        }
    }
}
