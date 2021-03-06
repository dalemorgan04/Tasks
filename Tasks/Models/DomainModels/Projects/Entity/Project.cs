﻿using System;
using System.Collections.Generic;
using Tasks.Models.DomainModels.Habits.Entity;
using Tasks.Repository.Core;

namespace Tasks.Models.DomainModels.Projects.Entity
{
    public class Project : IDomainEntity<int>
    {
        public virtual int Id { get; set; }        
        public virtual User User { get; set; }
        public virtual string Description { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual int TimeFrameId { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual bool IsComplete { get; set; }
    }
}

