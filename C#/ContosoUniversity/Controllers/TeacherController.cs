using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;

using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers

{
    public class TeacherController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Department
        public async Task<ActionResult> Index()
        {
           // var teachers = db.Teachers.Include(d => d.ID);
            return View(await db.Teachers.ToListAsync());
        }
        /*
        // GET: Department/Details/5
        public async Task
            <ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Commenting out original code to show how to use a raw SQL query.
            //Department department = await db.Departments.FindAsync(id);

            // Create and execute raw SQL query.
           string query = "SELECT * FROM Department WHERE DepartmentID = @p0";
    /        Department department = await db.Departments.SqlQuery(query, id).SingleOrDefaultAsync();

            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        */
        // GET: Department/Create
        public ActionResult Create()
        {
          //  ViewBag.ID = new SelectList(db.Teachers, "ID", "Name");
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Education,Innovation,Dissemination,Evaluation, Support")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(teacher);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

          //  ViewBag.ID = new SelectList(db.Teachers, "ID", "Name", teacher.ID);
            return View(teacher);
        }

        // GET: Department/Edit/5

    

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
  ///      [HttpPost, ActionName("Edit")]
   //     [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var teacherToUpdate = db.Teachers.Find(id);
            if (TryUpdateModel(teacherToUpdate, "",
               new string[] { "Name,Education,Innovation,Dissemination,Evaluation,Support" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(teacherToUpdate);
        }



        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id)
        {
            string[] fieldsToBind = new string[] { "ID,Name,Education,Innovation,Dissemination,Evaluation, Support" };

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var teacherToUpdate = await db.Teachers.FindAsync(id);
            if (teacherToUpdate == null)
            {
                Teacher deletedTeacher = new Teacher();
                TryUpdateModel(deletedTeacher, fieldsToBind);
                ModelState.AddModelError(string.Empty,
                    "Unable to save changes. The department was deleted by another user.");
           //     ViewBag.InstructorID = new SelectList(db.Instructors, "ID", "FullName", deletedTeacher.Teacher);
                return View(deletedTeacher);
            }

            if (TryUpdateModel(teacherToUpdate, fieldsToBind))
            {
                try
                {
                   db.Entry(teacherToUpdate).OriginalValues["ID"] = ID;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var entry = ex.Entries.Single();
                    var clientValues = (Teacher)entry.Entity;
                    var databaseEntry = entry.GetDatabaseValues();
                    if (databaseEntry == null)
                    {
                        ModelState.AddModelError(string.Empty,
                            "Unable to save changes. The department was deleted by another user.");
                    }
                    else
                    {
                        var databaseValues = (Teacher)databaseEntry.ToObject();

                        if (databaseValues.Name != clientValues.Name)
                            ModelState.AddModelError("Name", "Current value: "
                                + databaseValues.Name);
                        if (databaseValues.Education != clientValues.Education)
                            ModelState.AddModelError("Evalutation", "Current value: "
                                + String.Format("{0:c}", databaseValues.Innovation));
                        if (databaseValues.Innovation != clientValues.Innovation)
                            ModelState.AddModelError("Innovation", "Current value: "
                                + String.Format("{0:d}", databaseValues.Dissemination));
                        if (databaseValues.ID != clientValues.ID)
                            ModelState.AddModelError("ID", "Current value: "
                                + db.Instructors.Find(databaseValues.ID).FullName);
                        ModelState.AddModelError(string.Empty, "The record you attempted to edit "
                            + "was modified by another user after you got the original value. The "
                            + "edit operation was canceled and the current values in the database "
                            + "have been displayed. If you still want to edit this record, click "
                            + "the Save button again. Otherwise click the Back to List hyperlink.");
                        teacherToUpdate.ID = databaseValues.ID;
                    }
                }

        
        
                catch (RetryLimitExceededException )
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
         //   ViewBag.ID = new SelectList(db.Instructors, "ID", "FullName", teacherToUpdate.ID);
            return View(teacherToUpdate);
        }
        /*/
        // GET: Department/Delete/5
        public async Task<ActionResult> Delete(int? id, bool? concurrencyError)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = await db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                if (concurrencyError.GetValueOrDefault())
                {
                    return RedirectToAction("Index");
                }
                return HttpNotFound();
            }

            if (concurrencyError.GetValueOrDefault())
            {
                ViewBag.ConcurrencyErrorMessage = "The record you attempted to delete "
                    + "was modified by another user after you got the original values. "
                    + "The delete operation was canceled and the current values in the "
                    + "database have been displayed. If you still want to delete this "
                    + "record, click the Delete button again. Otherwise "
                    + "click the Back to List hyperlink.";
            }

            return View(teacher);
        }

        // POST: Department/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Teacher teacher)
        {
            try
            {
                db.Entry(teacher).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                return RedirectToAction("Delete", new { concurrencyError = true, id = teacher.ID });
            }
            catch (DataException )
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to delete. Try again, and if the problem persists contact your system administrator.");
                return View(teacher);
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
