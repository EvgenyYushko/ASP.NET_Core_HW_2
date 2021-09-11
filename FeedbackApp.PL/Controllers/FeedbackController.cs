using FeedbackApp.BLL.Interfaces;
using FeedbackApp.BLL.VMs.Feedback;
using FeedbackApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        public async Task<IActionResult> CreateFeedBack(FeedbackVM model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _userManager.GetUserAsync(User).Result;

                Guid guid = new Guid(currentUser.Id);

                CreateFeedback feedback = new CreateFeedback { UserId = guid, Text = model.Text, ProductCategory = "Телефоны", ProductName = "Самсунг", Rate = 2 };

                var result = await _feedbackService.CreateFeedbackAsync(feedback);

                var infoFb = _feedbackService.FindFeedbacksByFunc(f => f.Id == result).FirstOrDefault();
                model = new FeedbackVM { Text = infoFb.Text };
            }
           
            return View(model);
        }
    }
}
