using Stylet;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStyletProject.Pages
{
    class Page1ViewModel :Screen
    {
        public string Name { get; set; } = "大苹果";
        public string Title { get; set; } = "?";

        public Page1ViewModel(string num)
        {
            this.Title = $@"第{num}页";
            this.DisplayName = this.Title;
        }
    }
}
