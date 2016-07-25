using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP.BLL;
using ERP.Model;
namespace ERP
{
    public partial class ProductManagementWinForm : Form
    {
        public ProductManagementWinForm()
        {
            InitializeComponent();
        }
        private BLL.Product bllProduct = new BLL.Product();
        private BLL.Warehouse bllWarehouse = new ERP.BLL.Warehouse();
        private BLL.Statistics bllStatistics = new ERP.BLL.Statistics();
        private void ProductManagementWinForm_Load(object sender, EventArgs e)
        {
            foreach (string curPrdCategory in Enum.GetNames(typeof(ProductCategory)))
            {
                ProdCategory.Items.Add(curPrdCategory);
            }
            _loadData();
            _updateControlText(0);
        }


        //private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        //private SqlDataAdapter sad;
        private DataSet ds;
        private void _loadData()
        {
            try
            {
                ds = bllProduct.GetAllList();
                if (ds != null)
                {

                    ProductGridView.DataSource = ds.Tables[0];
                    ProductGridView.Columns["Sta_OID"].Visible = false;
                    ProductGridView.Columns["CreationDate"].Visible = false;
                    ProductGridView.Columns["ModifyDate"].Visible = false;
                    ProductGridView.Columns["ModifyUser"].Visible = false;
                    ProductGridView.Columns["Description"].Visible = false;

                }
                //if (connt.State == ConnectionState.Closed) { connt.Open(); }
                //string sql = "select Ident as 代码,Name as 名称,Category as 种类,Price as 价格 from Product group by Name,Ident,Category,Price order by Price";
                //sad = new SqlDataAdapter(sql, connt);
                //ds = new DataSet();
                //sad.Fill(ds, "sel");
                //ProductGridView.DataSource = ds.Tables["sel"];
            }
            catch (Exception err)
            {
                throw err;
            }
            

 
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            string theIdent = "";
            string theName = "";
            ProductCategory theCategory = ProductCategory.Undefined;
            
          

            try
            {
                if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
                {
                    if (bllProduct.GetModel(theIdent) != null)
                    {
                        throw new Exception("物料代码已存在!");
                    }
                    else
                    {
                        Model.Product newProduct = new Model.Product();
                        newProduct.Ident = theIdent;
                        newProduct.Name = theName;
                        newProduct.Price = 0;
                        newProduct.Category = theCategory;
                        newProduct.CreationDate = DateTime.Now;
                        bllProduct.Add(newProduct);
                        //create the statistics
                        Model.Statistics newStatistics = new ERP.Model.Statistics();
                        newStatistics.Product = newProduct;
                        newStatistics.War_OID = bllWarehouse.GetTop1Model().OID;
                        newStatistics.Number = 0;
                        bllStatistics.Add(newStatistics);

                        newProduct.Statistics = newStatistics;
                        bllProduct.Update(newProduct);
 
                    }
                    //if (connt.State == ConnectionState.Closed) { connt.Open(); }
                    //sel = "select count(*) from [ERPDatabase].[dbo].[Product] where [Ident] = '" + theIdent + "'";
                    //SqlCommand cmd = new SqlCommand(sel, connt);
                    //int theNum = int.Parse(cmd.ExecuteScalar().ToString());
                    //if (theNum > 0)
                    //{
                    //    throw new Exception("物料代码已存在!");
                    //}
                    //else
                    //{
                    //    sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + theIdent + "','" + theName + "'," + theCategory +",0,'" + SearchStr.CurrentUser +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                    //    SqlCommand insertCmd = new SqlCommand(sel, connt);
                    //    insertCmd.ExecuteNonQuery();
                    //}
                }
            }
            catch (Exception  err)
            {
                throw err;
            }

            _loadData();
        }

        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {

        }
        ///// <summary>
        ///// get all field from the database
        ///// </summary>
        ///// <param name="theIdent"></param>
        ///// <returns></returns>
        //private DataRow _getCurrentRow(string theIdent)
        //{
        //    try
        //    {
        //        //string sql = "select [Ident],[Name],[Category],[Price],[Description],[ModifyUser],[CreationDate],[ModifyDate] from [ERPDatabase].[dbo].[Product] Where [Ident] = '" + theIdent + "'";
        //        //sad = new SqlDataAdapter(sql, connt);
        //        //ds = new DataSet();
        //        //sad.Fill(ds, "sel");
        //        //currentTable = ds.Tables["sel"];
        //        //if (currentTable != null)
        //        //{
        //        //    return currentTable.Rows[0];
        //        //}
        //        //else
        //        //{
        //        //    return null;
        //        //}

        //    }
        //    catch (SqlException e)
        //    {

        //        throw e;
        //    }
            
        //}
        //private DataTable currentTable;
        //private DataGridViewRow currentGridViewRow;
        private Model.Product curProduct;
        private void _updateControlText(int theIndex)
        {
            try
            {

                int OID = int.Parse(ProductGridView.Rows[theIndex].Cells[0].Value.ToString());
                curProduct = bllProduct.GetModel(OID);
                if (curProduct != null)
                {
                    ProdIdent.Text = curProduct.Ident;
                    ProdName.Text = curProduct.Name;
                    ProdCategory.Text = Enum.GetName(typeof(ProductCategory), curProduct.Category);
                    ProdPrice.Text = curProduct.Price.ToString();
                    ProdDescription.Text = curProduct.Description;
                    ModifyUser.Text = curProduct.ModifyUser;
                    CreationDate.Text = curProduct.CreationDate.ToString();
                    ModifyDate.Text = curProduct.ModifyDate.ToString();
                }
                //if (currentGridViewRow == null)
                //{
                //    throw new Exception("the row is null");

                //}
                //else
                //{
                //    //get the data from the gridview directly
                //    ProdIdent.Text = currentGridViewRow.Cells[0].Value.ToString();
                //    ProdName.Text = currentGridViewRow.Cells[1].Value.ToString();
                //    ProdCategory.Text = Enum.GetName(typeof(ProductCategory), int.Parse(currentGridViewRow.Cells[2].Value.ToString()));
                //    ProdPrice.Text = currentGridViewRow.Cells[3].Value.ToString();
                //    // update other control
                //    DataRow currentRow = _getCurrentRow(ProdIdent.Text);
                //    ProdDescription.Text = currentRow[4].ToString();
                //    ModifyUser.Text = currentRow[5].ToString();
                //    CreationDate.Text = currentRow[6].ToString();
                //    ModifyDate.Text = currentRow[7].ToString();

                //}
            }
            catch (Exception e)
            {
                throw e;
            }

            
           
            
        }
        private int currentIndex; 
        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentIndex = e.RowIndex;
                _updateControlText(currentIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //currentGridViewRow = (DataGridViewRow)ProductGridView.Rows[e.RowIndex];
            
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (curProduct != null)
                {
                    bllProduct.Clone(curProduct);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
            //if (connt.State == ConnectionState.Closed) { connt.Open(); }

            //string sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + ProdIdent.Text.Trim() + "-1','" + ProdName.Text.Trim() + "'," + (byte)(ProductCategory)Enum.Parse(typeof(ProductCategory),ProdCategory.Text) + ",0,'" + SearchStr.CurrentUser + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            //SqlCommand insertCmd = new SqlCommand(sel, connt);
            //insertCmd.ExecuteNonQuery();
            //_loadData();
            //_updateControlText(currentIndex);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (curProduct != null)
                {
                    bllProduct.Delete(curProduct.OID);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (curProduct != null )
            {
                bllProduct.Update(curProduct);
            }
        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {
            curProduct.Name = ProdName.Text;
        }

        private void ProdDescription_TextChanged(object sender, EventArgs e)
        {
            curProduct.Description = ProdDescription.Text;
        }

        private void ProdCategory_TextChanged(object sender, EventArgs e)
        {
            ProductCategory theCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), ProdCategory.Text);
            curProduct.Category = theCategory;
        }

        private void ProdPrice_TextChanged(object sender, EventArgs e)
        {
            curProduct.Price = decimal.Parse(ProdPrice.Text);
        }

        private void ProductGridView_CursorChanged(object sender, EventArgs e)
        {

        }

        private void ProductGridView_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    currentIndex = ProductGridView.CurrentRow.Index;
                    _updateControlText(currentIndex);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
       
    }
}
