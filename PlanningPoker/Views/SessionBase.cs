﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MvvmBlazor.Components;
using PlanningPoker.ViewModels;
using System;

namespace PlanningPoker.Views
{
    public class SessionBase : MvvmComponentBase<SessionDetailViewModel>
    {
        [Parameter]
        public string SessionId { get; set; }
    }
}
