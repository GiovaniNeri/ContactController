using ContactController.DBContext;

namespace ContactController.Repositorio
{
    public interface IContatoRepositorio
    {
        List<Contact> BuscarTodos();
        Contact ListarPorID(int id);
        Contact Adicionar(Contact contact);
        Contact Atualizar(Contact contact)
    }
}
