using ContactController.DBContext;

namespace ContactController.Repositorio
{
    public interface IContatoRepositorio
    {
        List<Contact> BuscarTodos();
        Contact Adicionar(Contact contact);
    }
}
