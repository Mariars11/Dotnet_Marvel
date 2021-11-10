using System.Linq;
using Microsoft.AspNetCore.Mvc;
using src.Database;
using src.Dto;
using src.Models;

namespace src.Controllers
{
    //usar o folder src para identificar quais são as alterações feitas por você, e quais são geradas automaticamente
    [ApiController] //ctlr + (.) para importar coisas
    [Route("api/v1/heros")]
    public class HeroController
    {
        private DataContext _context; // _ usado para quando a variavel é privada
        public HeroController(DataContext context)
        {
            this._context = context;
        }
        [HttpPost] //get - equivalente ao select; Post - equivalente ao insert; Put / Patch - equivalente ao update  
        public Hero Create(CreateHero hero){
            var newHero = new Hero(hero);
            
            _context.heroes.Add(newHero);
            _context.SaveChanges();
            
            return newHero; 
        }

        [HttpGet("{id:int}")]
        public Hero GetById(int id){
            var result = _context.heroes.FirstOrDefault(h => h.Id == id);
            return result;
        }
    }
}