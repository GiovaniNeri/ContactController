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

        public Contact Atualizar(Contact contact)
        {
            Contact contatoDB = ListarPorID(contact.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro ao atualizar o contato");

            contatoDB.Name = contact.Name;
            contatoDB.Email = contact.Email;
            contatoDB.Contato = contact.Contato;

            _contactContext.Contacts.Update(contatoDB);
            _contactContext.SaveChanges(true);
            return contatoDB;
        }
    }
}
