﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Tasks.Models.Core;
using Tasks.Models.DomainModels;
using Tasks.Repository.Thoughts;
using Tasks.Service.Tasks;
using Tasks.Service.Tasks.Dto;
using Tasks.Service.Thoughts;
using Tasks.Service.Thoughts.Dto;
using Tasks.Service.Users;
using Tasks.Service.Users.Dto;
using Tasks.ViewModels.Thoughts;

namespace Tasks.Controllers
{
    public class ThoughtsController : Controller
    {
        private readonly IUserService userService;
        private readonly IThoughtService thoughtService;

        public ThoughtsController(
            IThoughtService thoughtService,
            ITaskService taskService,
            IUserService userService)
        {
            this.thoughtService = thoughtService;
            this.userService = userService;
        }
        // GET: Inbox
        public ActionResult Index()
        {
            List<ThoughtDto> thoughtList = thoughtService.GetThoughts().ToList();

            int userId = 1;
            if (userId == 0)
                throw new ArgumentNullException("value");

            UserDto user = userService.GetUser(userId);
            AddThoughtViewModel addThoughtViewModel = new AddThoughtViewModel();
            ThoughtsViewModel viewModel = new ThoughtsViewModel {ThoughtList = thoughtList, User = user, NewThought = addThoughtViewModel};

            return View(viewModel);
        }

        [HttpPost]
        public bool Create(AddThoughtViewModel viewModel)
        {
            ThoughtDto thought = new ThoughtDto();
            thought.Description = viewModel.Description;
            thought.DateCreated = DateTime.Now;
            thought.User = Mapper.Map<UserDto, User>(userService.GetUser(1));
            thoughtService.Save(thought);
            return true;
        }
        
        [HttpPost]
        public ActionResult GetThoughtsTable()
        {
            List<ThoughtDto> thoughtList = thoughtService.GetThoughts().ToList();
            ThoughtsViewModel viewModel = new ThoughtsViewModel { ThoughtList = thoughtList };
            return PartialView("_ThoughtsTable", viewModel);
        }

        [HttpPost]
        public bool DeleteThought(int thoughtId)
        {
            thoughtService.Delete(thoughtId);
            return true;
        }

        [HttpPost]
        public bool MoveThought(int thoughtId, int moveToSortId)
        {
            thoughtService.UpdateSortId(thoughtId,moveToSortId);
            return true;
        }

        private bool isValidViewModel(ThoughtEditViewModel viewModel)
        {
            return true; //TODO
        }
    }
}