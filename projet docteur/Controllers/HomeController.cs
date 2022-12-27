using projet_docteur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projet_docteur.Controllers
{
    public class HomeController : Controller
    {
        private static List<user> users = new List<user>();
        private static List<docteur> doctors = new List<docteur>();
        private static int cptu = 1;
        private static int cptd = 1;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listerdocuser()
        {
            return View(doctors);
        }

        public ActionResult listerdocuseradm()
        {
            return View(doctors);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public void vzero()
        {
            user admin = new user(0, "System", "admin@admin.com", "admin123");
            users.Add(admin);
        }

        public ActionResult Create([Bind(Include = "nom,spec,addres,telephone,dispo")] docteur doctor)
        {
            if (ModelState.IsValid)
            {

                doctor.id = cptd++;
                doctors.Add(doctor);
                return RedirectToAction("Create");
            }
            return View();
        }

        public ActionResult Register([Bind(Include = "nom,mail,pass")] user user1)
        {
            if (ModelState.IsValid)
            {
                user1.id = cptu++;
                users.Add(user1);
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        public ActionResult Login([Bind(Include = "Email,Password")] testio auth)
        {
            if (doctors.Count == 0)
                vzero();
            if (ModelState.IsValid)
            {

                for (int i = 0; i < users.Count ; i++)
                {

                    if (auth.Email == "admin@admin.com" && auth.Password == "admin123")
                    {
                       

                        return RedirectToAction("listerdocuseradm", "Home");
                    }
                    else if (auth.Email == users[i].mail && auth.Password == users[i].pass)
                    {
                        
                        return RedirectToAction("listerdocuser", "Home");
                    }
                }

            }
            return View();
        }

        public ActionResult Edit([Bind(Include = "nom,spec,addres,telephone,dispo")] docteur doctor, int? id)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < doctors.Count; i++)
                {
                    if (doctors[i].id == id)
                    {
                        doctors[i].nom = doctor.nom;
                        doctors[i].spec = doctor.spec;
                        doctors[i].addres = doctor.addres;
                        doctors[i].dispo = doctor.dispo;
                    }
                }
                return RedirectToAction("listerdocuseradm");
            }
            return View(doctor);
        }

        public ActionResult Delete(int? id)
        {
            var itemToRemove = doctors.Find(r => r.id == id);

            doctors.Remove(itemToRemove);
            return RedirectToAction("listerdocuseradm");
        }
        public ActionResult Disconnect()
        {
            return RedirectToAction("Login");
        }


    }
}