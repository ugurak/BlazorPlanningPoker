﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlanningPoker.Events
{
    public class UserConnectedToSessionEventArgs : EventArgs
    {
        public ClaimsPrincipal User { get; set; }

        public string SessionId { get; set; }

        public UserConnectedToSessionEventArgs(ClaimsPrincipal user, string sessionId)
        {
            User = user;
            SessionId = sessionId;
        }
    }
}
