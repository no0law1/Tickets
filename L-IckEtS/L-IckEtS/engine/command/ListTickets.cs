﻿using L_IckEtS.command.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.command
{
    class ListTickets : ICommand
    {

        private Boolean nonClosed;

        public ListTickets(Boolean nonClosed)
        {
            this.nonClosed = nonClosed;
        }

        public void execute()
        {

        }
    }
}
