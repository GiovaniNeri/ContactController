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

        public ContactContext Get_contactContext()
        {
            return _contactContext;
        }

        public Contact ListarPorID(int id, ContactContext _contactContext)
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
            Contact contatoDB = ListarPorID(contact.Id, Get_contactContext());
            if (contatoDB == null) throw new System.Exception("Houve um erro ao atualizar o contato");

            contatoDB.Name = contact.Name;
            contatoDB.Email = contact.Email;
            contatoDB.Contato = contact.Contato;

            _contactContext.Contacts.Update(contatoDB);
            _contactContext.SaveChanges(true);
            return contatoDB;
        }

        public bool Apagar(int id)
        {
            Contact contatoDB = ListarPorID(id);
            if (contatoDB == null) throw new System.Exception("Houve um erro ao remover o contato");
            _contactContext.Contacts.Remove(contatoDB);
            _contactContext.SaveChanges();
            return true;
        }

        public Contact ListarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
