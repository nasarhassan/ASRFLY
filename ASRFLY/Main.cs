using ASRFLY.Data;


namespace ASRFLY
{
    public partial class Main : Form


    {
        private readonly PageManager pageManager;//object

        public Main()
        {
            InitializeComponent();

            pageManager = new PageManager(this);
            //LOAD HomePage 
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)

        { //LOAD HomePage 
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #endregion

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
