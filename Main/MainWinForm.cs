using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class MainWinForm : Form
    {
        public MainWinForm()
        {
            InitializeComponent();
        }

        private void ProductManagement_Click(object sender, EventArgs e)
        {
            try
            {
                ProductManagementWinForm proWF = new ProductManagementWinForm();
                proWF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExitConfirmWinForm exitform = new ExitConfirmWinForm();
                exitform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void MainWinForm_Load(object sender, EventArgs e)
        {
            try
            {
                int theX = UserNamelabel.Location.X;
                int theY = this.Location.Y - UserNamelabel.Width;

                UserNamelabel.Location = new Point(theX, theY);
                UserNamelabel.Text = Program.CurrentUser.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void RecepitSubMenu_Click(object sender, EventArgs e)
        {
            try
            {
                RecepitWinForm recFrom = new RecepitWinForm();
                recFrom.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void StatisticsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                ProductStatisticsWinForm proStaForm = new ProductStatisticsWinForm();
                proStaForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void DispatchSubMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DispatchWinForm disForm = new DispatchWinForm();
                disForm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
 
            }
            
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExitConfirmWinForm exitform = new ExitConfirmWinForm();
                exitform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void AboutSubMenu_Click(object sender, EventArgs e)
        {
            AboutSystem aboutForm = new AboutSystem();
            aboutForm.ShowDialog();
        }

        private void AgentToolStripMenu_Click(object sender, EventArgs e)
        {
            AgentManagementWinForm AgentForm = new AgentManagementWinForm();
            AgentForm.ShowDialog();
        }

        private void ExpectedReceiptAccountMenuItem_Click(object sender, EventArgs e)
        {
            ExpectReceiptAccountWinForm expAccountForm = new ExpectReceiptAccountWinForm();
            expAccountForm.ShowDialog();

        }

        

   
       
    }
}
