﻿using System.Collections.Generic;
using Tasks.Service.Projects.Dto;

namespace Tasks.ViewModels.Projects
{
    public class ProjectsViewModel
    {
        public List<ProjectWithItemsDto> Projects { get; set; }
    }
}