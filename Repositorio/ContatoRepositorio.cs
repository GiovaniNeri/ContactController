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
        public List<Contact> BuscarTodos()
        {
            return _contactContext.Contacts.ToList();
        }
        public Contact ListarPorID(int id)
        {
            return _contactContext.Contacts.FirstOrDefault(x => x.Id == id);
        }
        public Contact Adicionar(Contact contact)
        {
            _contactContext.Contacts.Add(contact);
            _contactContext.SaveChanges();
            return contact;
        }

        
    }
}
