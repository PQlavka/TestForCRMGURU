namespace TestForCRMGURU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonAllDB = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.sqlConnectionMain = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandAddCountryProc = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 225);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(493, 196);
            this.dataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна (on english pls)";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(178, 10);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(150, 22);
            this.textBoxCountry.TabIndex = 2;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(334, 10);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(113, 23);
            this.buttonGet.TabIndex = 3;
            this.buttonGet.Text = "Получить";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.ButtonGet_Click);
            // 
            // buttonAllDB
            // 
            this.buttonAllDB.Location = new System.Drawing.Point(12, 196);
            this.buttonAllDB.Name = "buttonAllDB";
            this.buttonAllDB.Size = new System.Drawing.Size(493, 23);
            this.buttonAllDB.TabIndex = 4;
            this.buttonAllDB.Text = "Все страны в БД";
            this.buttonAllDB.UseVisualStyleBackColor = true;
            this.buttonAllDB.Click += new System.EventHandler(this.ButtonAllDB_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(16, 38);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(328, 148);
            this.listBoxResult.TabIndex = 5;
            // 
            // sqlConnectionMain
            // 
            this.sqlConnectionMain.ConnectionString = "Data Source=DESKTOP-FCTVBII;Initial Catalog=localcsharp;Integrated Security=True";
            this.sqlConnectionMain.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandAddCountryProc
            // 
            this.sqlCommandAddCountryProc.CommandText = "AddCountry";
            this.sqlCommandAddCountryProc.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandAddCountryProc.Connection = this.sqlConnectionMain;
            this.sqlCommandAddCountryProc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@capital", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@code", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@pop", System.Data.SqlDbType.BigInt, 8)});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnectionMain;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cities", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Name", "Name"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Capital", "Capital"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("Population", "Population"),
                        new System.Data.Common.DataColumnMapping("Space_m2", "Space_m2")})});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(517, 433);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonAllDB);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonAllDB;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Data.SqlClient.SqlConnection sqlConnectionMain;
        private System.Data.SqlClient.SqlCommand sqlCommandAddCountryProc;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}

