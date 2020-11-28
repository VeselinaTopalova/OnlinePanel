namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Users;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ISurveyService surveyService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public UsersController(IUsersService usersService, ISurveyService surveyService, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            this.usersService = usersService;
            this.surveyService = surveyService;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult SurveysForUser(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new SyrveysListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                RecipesCount = this.surveyService.GetCount(),
                Surveys = this.surveyService.GetAll<SurveyInListViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            return this.View(survey);
        }

        public IActionResult CompleteSurvey(int id)
        {
            var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            return this.View(survey);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteSurvey(SingleSurveyViewModel input, int id)
        {
            Console.WriteLine(input.ToString());
            var user = await this.userManager.GetUserAsync(this.User);
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            ;

            ;

            //await this.usersService.CreateAsync(input, id, user.Id);

            // TODO: Redirect to ???
            return this.Redirect("/");
        }
        public IActionResult AddAnswers(int id)
        {
            var model = new PeopleSelectionViewModel();

            var syrvey = this.db.Surveys.FirstOrDefault(x => x.Id == id);
            var questions1 = this.db.Questions.Where(x => x.SurveyId == id).ToArray();
            var questions = this.db.Questions.Where(x => x.SurveyId == id).Select(s => new 
            {
                Id = s.Id,
                Name = s.Name,
                Answers = s.Answers
                        .Select(g => new
                        {
                            Id = g.Id,
                            Name = g.Name,
                        })
             }).ToArray();
            var qc = questions.Count();

            ;
            foreach (var question in questions)
            {
                foreach (var ans in question.Answers)
                {
                    var editorViewModel = new SelectAnswerEditorViewModel()
                    {
                        Id = ans.Id,
                        Name = ans.Name,
                        Selected = true
                    };
                    model.Answers.Add(editorViewModel);
                }
            }
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddAnswers(PeopleSelectionViewModel model, int id)
        {
            // get the ids of the items selected:
            var selectedIds = model.getSelectedIds();
            ;

            // Use the ids to retrieve the records for the selected people
            // from the database:
            //var selectedPeople = from x in  //Db.People
            //                     where selectedIds.Contains(x.Id)
            //                     select x;

            //// Process according to your requirements:
            //foreach (var person in selectedPeople)
            //{
            //    System.Diagnostics.Debug.WriteLine(
            //        string.Format("{0} {1}", person.firstName, person.LastName));
            //}

            // Redirect somewhere meaningful (probably to somewhere showing 
            // the results of your processing):
            //await this.usersService.CreateAsync(input, id, user.Id);

            // TODO: Redirect to ???
            return this.Redirect("/");
        }


    }
}
