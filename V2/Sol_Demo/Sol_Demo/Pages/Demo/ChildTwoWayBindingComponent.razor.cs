using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ChildTwoWayBindingComponent
    {
        [Parameter]
        public String Message { get; set; }

        [Parameter]
        public EventCallback<String> MessageChanged { get; set; }

        public async Task OnChildButtonClickEvent()
        {
            Message = "Child Two Binding : Hello";
            await MessageChanged.InvokeAsync(Message);
        }
    }
}