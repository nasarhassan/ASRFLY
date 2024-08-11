using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl

    
    {
        private  static HomeUserControl _HomeUserControl;

        public HomeUserControl()
        {
            InitializeComponent();
        }

        public static HomeUserControl Instance()// Singalton method
        { return _HomeUserControl ?? (new HomeUserControl());
        }
    }
}
