﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_CQRS.Commands
{
    public interface ICommand
    {
        public Guid CommandId { get; set; }
    }
}
