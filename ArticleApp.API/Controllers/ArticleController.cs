using System.Collections.Generic;
using System.Linq;
using ArticleApp.API.Data;
using Microsoft.AspNetCore.Mvc;


namespace ArticleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private DataContext _context =null;

        public ArticleController(DataContext contexte){
            _context = contexte;
        }

        [HttpGet]
        public ActionResult GetArticles(){
            return Ok(_context.Articles.ToList());
        }
        
    }
}