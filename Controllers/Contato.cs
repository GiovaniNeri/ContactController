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
        public IActionResult Editar(int id)
        {
            Contact contato = _contatoRepositorio.ListarPorID(id, _contatoRepositorio.Get_contactContext());
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            Contact contato = _contatoRepositorio.ListarPorID(id, _contatoRepositorio.Get_contactContext());
            return View(contato);
        }

        [HttpPost]
        public IActionResult Criar(Contact contact)
        {
            _contatoRepositorio.Adicionar(contact);
            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(Contact contact)
        {
            _contatoRepositorio.Atualizar(contact);
            return RedirectToAction("Index");
        }
    }
}
