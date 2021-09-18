using FeedbackApp.BLL.Interfaces;
using FeedbackApp.BLL.VMs.Feedback;
using FeedbackApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.PL.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(UserManager<User> userManager, IFeedbackService feedbackService)
        {
            _userManager = userManager;
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public IActionResult CreateFeedBack()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeedBackList()
        {
            var infoFeedBackList = _feedbackService.FindFeedbacksByFunc(null);
            return View(infoFeedBackList);
        }

        [HttpGet]
        public ActionResult GetFeedbackById(Guid id)
        {
            var feedback = _feedbackService.FindFeedbacksByFunc(f => f.Id == id).SingleOrDefault();
            return View(feedback);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeedBack(FeedbackVM model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _userManager.GetUserAsync(User).Result;

                Guid guid = new Guid(currentUser.Id);

                CreateFeedback feedback = new CreateFeedback
                {
                    UserId = guid,
                    Text = model.Text,
                    ProductCategory = model.ProductCategory,
                    ProductName = model.ProductName,
                    Rate = model.Rate
                };

                var feedBackId = await _feedbackService.CreateFeedbackAsync(feedback);
                return RedirectToAction(nameof(GetFeedbackById), feedBackId);
            }

            return View();
        }
    }
}
