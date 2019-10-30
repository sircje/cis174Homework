using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer.Design;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment10_1Controller : Controller
    {/*not needed
        // GET: Assignment10_1
        

        // GET: Assignment10_1
        public ActionResult FamousPeopleList()
        {
            var gwAchievementList = new List<Achievements>{
                          new Achievements() { AchievementsId = 1, FamousPeopleId = 1, name = "Became President", doa = "April 30, 1789" } ,
                          new Achievements() { AchievementsId = 2, FamousPeopleId = 1, name = "Was Born", doa = "November 16, 1732"}
                        };
            var teAchievementList = new List<Achievements>{
                          new Achievements() { AchievementsId = 3, FamousPeopleId = 2, name = "Invent the lightbulb", doa = "November, 1879" } ,
                          new Achievements() { AchievementsId = 4, FamousPeopleId = 2, name = "Was Born", doa = "February 11, 1847"},
                          new Achievements() { AchievementsId = 5, FamousPeopleId = 2, name = "Invent a motion picture camera", doa = "February 1893"}
                        };
            var famousList = new List<FamousPeople>{
                          new FamousPeople() {firstName = "George", FamousPeopleId = 1, lastName = "Washington", birthDate = "November 16, 1732" , city = "Pope's Creek", state = "Virginia", Achievements = gwAchievementList },
                          new FamousPeople() {firstName = "Thomas", FamousPeopleId = 2, lastName = "Edison", birthDate = "February 11, 1847" , city = "Milan", state = "Ohio", Achievements = teAchievementList }
                        };
            return View(famousList);
        }
        [Route("Assignment10_1/yeet")]
        public ActionResult Details(int id)
        {

            var gwAchievementList = new List<Achievements>{
                          new Achievements() { AchievementsId = 1, FamousPeopleId = 1, name = "Became President", doa = "April 30, 1789" } ,
                          new Achievements() { AchievementsId = 2, FamousPeopleId = 1, name = "Was Born", doa = "November 16, 1732"}
                        };
            var teAchievementList = new List<Achievements>{
                          new Achievements() { AchievementsId = 3, FamousPeopleId = 2, name = "Invent the lightbulb", doa = "November, 1879" } ,
                          new Achievements() { AchievementsId = 4, FamousPeopleId = 2, name = "Was Born", doa = "February 11, 1847"},
                          new Achievements() { AchievementsId = 5, FamousPeopleId = 2, name = "Invent a motion picture camera", doa = "February 1893"}
                        };
            var famousList = new List<FamousPeople>{
                          new FamousPeople() {firstName = "George", FamousPeopleId = 1, lastName = "Washington", birthDate = "November 16, 1732" , city = "Pope's Creek", state = "Virginia", Achievements = gwAchievementList },
                          new FamousPeople() {firstName = "Thomas", FamousPeopleId = 2, lastName = "Edison", birthDate = "February 11, 1847" , city = "Milan", state = "Ohio", Achievements = teAchievementList }
                        };
            var AchievementList = new List<Achievements> { };
            foreach (var item in famousList) { if (id == item.FamousPeopleId) { AchievementList = item.Achievements.ToList(); } };
                return View(AchievementList);
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: Assignment10_1/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assignment10_1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assignment10_1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Assignment10_1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assignment10_1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Assignment10_1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}