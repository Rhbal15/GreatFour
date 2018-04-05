using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Hurwitz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetVisibleHelpLink(false);
        }

        private void Laplace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetVisibleHelpLink(false);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SetVisibleHelpLink(true);
        }

        private void SetVisibleHelpLink(bool isVisible)
        {
            Hurwitz.Visible = isVisible;
            Laplace.Visible = isVisible;
            Savige.Visible = isVisible;
            Vald.Visible = isVisible;

            Exit.Visible = isVisible;

            HelpText.Visible = !isVisible;
            Back.Visible = !isVisible;
        }

        private void Vald_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetVisibleHelpLink(false);
        }

        private void Savige_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetVisibleHelpLink(false);
        }
    }
}
