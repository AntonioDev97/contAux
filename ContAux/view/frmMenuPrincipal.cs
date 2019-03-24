using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAux.view
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            pnItem1.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, pnItem1);
            pnItem1.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, pnItem1);
            lblItem1.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, lblItem1);
            lblItem1.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, lblItem1);
            picItem1.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, picItem1);
            picItem1.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, picItem1);
            pnItem2.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, pnItem2);
            pnItem2.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, pnItem2);
            lblItem2.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, lblItem2);
            lblItem2.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, lblItem2);
            picItem2.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, picItem2);
            picItem2.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, picItem2);
            pnItem3.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, pnItem3);
            pnItem3.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, pnItem3);
            lblItem3.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, lblItem3);
            lblItem3.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, lblItem3);
            picItem3.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, picItem3);
            picItem3.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, picItem3);
            pnItem4.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, pnItem4);
            pnItem4.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, pnItem4);
            lblItem4.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, lblItem4);
            lblItem4.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, lblItem4);
            picItem4.MouseEnter += (sender, e) => HoverEnterMenu(sender, e, picItem4);
            picItem4.MouseLeave += (sender, e) => HoverLeaveMenu(sender, e, picItem4);
        }

        private void HoverEnterMenu(object sender, EventArgs e, Control p)
        {
            if (p is Panel)
                p.BackColor = Color.FromArgb(50, 68, 182);
            else
                p.Parent.BackColor = Color.FromArgb(50, 68, 182);
        }
        private void HoverLeaveMenu(object sender, EventArgs e, Control p)
        {
            if (p is Panel)
                p.BackColor = LayMenu.BackColor;
            else
                p.Parent.BackColor = LayMenu.BackColor;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
