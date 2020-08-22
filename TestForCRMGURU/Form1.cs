using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TestForCRMGURU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGet_Click(object sender, EventArgs e)
        {
            buttonGet.Visible = false;
            if (textBoxCountry.Text != "") {
                API_CRMGURU api = new API_CRMGURU(textBoxCountry.Text); //API init
                api.GetInfo(); //API get content JSON (api.result = json object)
                int waitmeter = 0;
                while (!api.result.Loaded && waitmeter <= 500) { //for async 
                    Thread.Sleep(10);
                    waitmeter++;
                }
                try
                {
                    listBoxResult.Items.Clear();
                    listBoxResult.Items.Add("Название: " + api.result.MyArray[0].name);
                    listBoxResult.Items.Add("Код страны: " + api.result.MyArray[0].alpha2Code);
                    listBoxResult.Items.Add("Столица: " + api.result.MyArray[0].capital);
                    listBoxResult.Items.Add("Площадь: " + api.result.MyArray[0].area + " км2");
                    listBoxResult.Items.Add("Население: " + api.result.MyArray[0].population + " чел.");
                    listBoxResult.Items.Add("Регион: " + api.result.MyArray[0].region);
                    sqlCommandAddCountryProc.Parameters["@name"].Value = api.result.MyArray[0].name;
                    sqlCommandAddCountryProc.Parameters["@capital"].Value = api.result.MyArray[0].capital;
                    sqlCommandAddCountryProc.Parameters["@region"].Value = api.result.MyArray[0].region;
                    sqlCommandAddCountryProc.Parameters["@code"].Value = api.result.MyArray[0].alpha2Code;
                    sqlCommandAddCountryProc.Parameters["@area"].Value = api.result.MyArray[0].area;
                    sqlCommandAddCountryProc.Parameters["@pop"].Value = api.result.MyArray[0].population;
                    //Настройки подключения к MS SQL выполняются из конструктора формы в поле ConnectionString элемента sqlConnectionMain (считаю это наиболее удобным для программиста методом подключения, т.к. настройки тянутся автоматически)
                    //sqlConnectionMain.ConnectionString = "Data Source=DESKTOP-FCTVBII;" +
                    //                                     "Initial Catalog=localcsharp;" +
                    //                                     "Integrated Security=True";

                    sqlConnectionMain.Open();
                    sqlCommandAddCountryProc.ExecuteNonQuery(); //AddCountry procedure
                    sqlConnectionMain.Close();
                }
                catch (Exception err)
                {
                    listBoxResult.Items.Clear();
                    listBoxResult.Items.Add("Err: 404 Not Founded" );
                }
                buttonGet.Visible = true;
            }
        }

        private void ButtonAllDB_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            sqlConnectionMain.Open();
            DataSet ds = new DataSet();
            sqlDataAdapter1.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            sqlConnectionMain.Close();
        }
    }
}
