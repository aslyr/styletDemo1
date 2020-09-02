
using HandyControl.Controls;
using Stylet;

namespace Company.WpfApplication1.Pages
{
    public class ShellViewModel : Screen
    {

        public void ShowMessage()
        {   
           
        }
        public string Name { get; set; } = "欢迎管理岗";
        public int pageIndex { get; set; } = 12;
        public void PageUpdate()
        {   
            MessageBox.Show(pageIndex.ToString());
        }
    }
}
