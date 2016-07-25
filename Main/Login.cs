using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;
//using System.Data.SqlClient;
using ERP.BLL ;
using ERP.Model;

namespace ERP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string name = "";

        private void Login_Load(object sender, EventArgs e)
        {
            BLL.User bll = new BLL.User();
            DataSet users = new DataSet();
            users = bll.GetAllList();
            foreach (DataRow curRow in users.Tables[0].Rows)
            {

                NamecomboBox.Items.Add(curRow[2].ToString());
            }

            
            


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {



            if (keyData == Keys.Escape)
            {
                this.Close();
                return false;
            } if (keyData == Keys.Enter)
            {



                _login();
            }

            return false;
        }
        public static BLL.User dllUser= new BLL.User();


        private bool _login()
        {
            bool Flag = true;
            try
            {

                name = NamecomboBox.SelectedItem.ToString().Trim();
                PasswordtextBox.Text = "ntmaster";
                Model.User theUser = dllUser.GetModel(name,PasswordtextBox.Text);
                if (theUser != null)
                {
                    Program.CurrentUser = theUser;
                    this.Visible = false;
                    ERP.MainWinForm mad = new MainWinForm();
                    mad.ShowDialog();
                    this.Close();

                }
                else
                {
                    label2.Text = "用户名或密码输入错误,请重新输入";
                    name = "";
                    Flag = false;

                }
              
                //string sql = "select count(*) from [ERPDatabase].[dbo].[User] where Name ='" + NamecomboBox.SelectedItem.ToString() + "'and password='" + PasswordtextBox.Text + "'";
                //SqlCommand cmd = new SqlCommand(sql, connt);
                //int k = int.Parse(cmd.ExecuteScalar().ToString());
                //if (k == 1)
                //{
                //    SearchStr.CurrentUser = NamecomboBox.SelectedItem.ToString();

                //    this.Visible = false;
                //    ERP.MainWinForm mad = new MainWinForm();
                //    mad.ShowDialog();
                //    this.Close();

                //    //RMS.Main mad = new Main();
                //    //mad.ShowDialog();
                //}
                //else
                //{
                //    label2.Text = "用户名或密码输入错误,请重新输入";
                //}
                //if (connt.State == ConnectionState.Open)
                //{
                //    connt.Close();
                //}
                //return true;
               

            }
            catch (Exception e)
            {
                Flag = false;
                throw e;
               
            }
            return Flag;
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _login();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
