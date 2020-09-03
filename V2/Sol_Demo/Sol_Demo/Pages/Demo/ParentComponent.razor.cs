using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class ParentComponent
    {
        [Parameter]
        public String Message { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Message = "Hello...";

                StateHasChanged();
            }
        }

        public void OnParentButtonClickEvent()
        {
            Message = "Parent : Hello";
        }

        private void GetChildMessageByEventCallBack(string message)
        {
            Message = message;
        }
    }
}