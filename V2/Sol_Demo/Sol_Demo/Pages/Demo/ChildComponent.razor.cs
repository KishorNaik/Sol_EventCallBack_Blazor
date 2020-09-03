using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ChildComponent
    {
        [Parameter]
        public String Message { get; set; }

        [Parameter]
        public EventCallback<String> MessageChanged { get; set; }

        #region Event

        public async Task OnChildButtonClickEvent()
        {
            Message = "Child : Hello";
            await MessageChanged.InvokeAsync(Message);
        }

        #endregion Event
    }
}