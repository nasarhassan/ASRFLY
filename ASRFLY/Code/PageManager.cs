using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ASRFLY.Data
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //load old page 
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);//remove oldpage
                //remove variable from memory
                oldPage.Dispose();
            }

            //load new Page
            PageUserControl.Dock = DockStyle.Fill; //ضمان عملية الاحتواء الكامل
            main.panelContainer.Controls.Add(PageUserControl);

        }


    }
}
