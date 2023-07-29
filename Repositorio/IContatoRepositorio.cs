using ContactController.DBContext;

namespace ContactController.Repositorio
{
    public interface IContatoRepositorio
    {
        Contact Adicionar(Contact contact);
    }
}
