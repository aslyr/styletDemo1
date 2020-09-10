using System.Collections.Generic;
using Stylet;
using System;
using System.Collections.ObjectModel;
using MyStyletProject.Pages;
using StyletIoC;
using System.Windows.Controls;

namespace Company.WpfApplication1.Pages
{
    public class ShellViewModel : Conductor<Screen>.Collection.OneActive
    {
        public BindableCollection<Screen> Items { get; set; } = new BindableCollection<Screen>();
        private readonly IContainer container;
        public void ShowMessage()
        {   
           
        }
        public string Name { get; set; } ="dfdfjdfk";
        public int pageIndex { get; set; } = 12;
        public DateTime Sdate { get; set; }
        public ObservableCollection<Stduent> lists { get; set; } = new ObservableCollection<Stduent>();
        public ShellViewModel( IContainer container)
        {
            this.container = container;
            Items.Add(new Page1ViewModel(Items.Count.ToString()));
            Items.Add(new Page1ViewModel(Items.Count.ToString()));
            for (int i = 0; i < 30; i++)
            {
                var s = new Stduent()
                {
                    Age = i,
                    Name = "gaokai" + i.ToString(),
                    Hobbits = new List<string>()
                    {
                        "play basketball",
                        "ssc"
                    }

                };
                this.lists.Add(s);
               
            }
        }
        public void NewTab()
        {
            var page = new Page1ViewModel(Items.Count.ToString());
            Items.Add(page);
            this.ActiveItem = page;
        }
    }
}
