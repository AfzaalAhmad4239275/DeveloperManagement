using Developer.Data;
using Developer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Developer.Controllers
{
    public class DeveloperController : Controller
    {
        public readonly ApplicationDbContext _context;


        public DeveloperController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public JsonResult GetAlldevelopers()
        {
            var devList = _context.Developers.ToList().OrderBy(x => x.Id);
            return Json(new { data = devList });
        }

        [HttpPost]
        public ActionResult savedeveloper(List<Developers> Developerlist)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach(var dev in Developerlist)
                    {
                        Developers oldobjWithName = _context.Developers.Where(x => x.Name.ToLower() == dev.Name ).FirstOrDefault();
                        bool alreadyExist = false;
                        if (oldobjWithName != null)
                        {
                            alreadyExist = true;
                        }
                        if (alreadyExist)
                        {
                            return Json(new { alreadyExist });
                        }
                        _context.Add(dev);
                        _context.SaveChanges();
                    }
                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return Json(new { status = false });

                }
            }
                return Json(new { status  = true });
            
        }
         
        public ActionResult DeleteDeveloper(int Id)
        {
            try
            {
                var developer = _context.Developers.Find(Id);
                _context.Developers.Remove(developer);
                _context.SaveChanges();
                return Json(new { status = true });
            }
            catch (Exception ex)
            {
                return Json(new { status = false });
            }
        }  

        public IActionResult EditDeveloper(int id)
        {
            var developer = _context.Developers.Find(id);
            return new JsonResult(developer);
        }

        [HttpPost]
        public ActionResult UpdateDeveloper(Developers obj)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Developers oldobjWithName = _context.Developers.Where(x => x.Name.ToLower() == obj.Name && x.Id !=obj.Id).FirstOrDefault();
                    bool alreadyExist = false;
                    if (oldobjWithName != null)
                    {
                        alreadyExist = true;
                    }
                    if (alreadyExist)
                    {
                        return Json(new { alreadyExist });

                    }

                    _context.Update(obj);
                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return Json(new { status = false });

                }
            }
            return Json(new { status = true });
        }
    }
}
