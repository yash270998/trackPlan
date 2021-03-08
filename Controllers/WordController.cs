using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult postWord(string word)
        {
            //....
            Word newWord = new Word();
            newWord.word = word;
            //            return "<b>ok</b>" + word;
            ViewBag.Message = newWord;

            return View();


        }

    }
}