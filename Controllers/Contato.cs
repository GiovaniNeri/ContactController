using ContactController.DBContext;
using ContactController.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContactController.Controllers
{
    public class Contato : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public Contato(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<Contact> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contact contact)
        {
            _contatoRepositorio.Adicionar(contact);
            return RedirectToAction("Index");
        }
    }
}
