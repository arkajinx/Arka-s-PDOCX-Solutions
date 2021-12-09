using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Arka_s_PDOCX_Solutions
{
    public partial class frmOK : MaterialSkin.Controls.MaterialForm
    {
        public frmOK()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, Accent.Red700, MaterialSkin.TextShade.BLACK);
        }

        public string Message
        {
            get { return lblOK.Text; }
            set { lblOK.Text = value; }
        }
    }
}
