namespace dashboard_medios
{
    partial class take_over_bd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(take_over_bd));
            this.deleteRow = new MetroFramework.Controls.MetroButton();
            this.add = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.registroFechasMedia = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textFecha = new MetroFramework.Controls.MetroTextBox();
            this.programing = new MetroFramework.Controls.MetroButton();
            this.timer_banner_bdm = new Syncfusion.WinForms.Input.SfCalendar();
            this.account_text = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.hotel_combo = new MetroFramework.Controls.MetroTextBox();
            this.fecha_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registroFechasMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(28, 500);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(115, 23);
            this.deleteRow.TabIndex = 52;
            this.deleteRow.Text = "Borrar seleccionado";
            this.deleteRow.UseSelectable = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(296, 247);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 23);
            this.add.TabIndex = 51;
            this.add.Text = "Agregar a lista";
            this.add.UseSelectable = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 279);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Lista Fechas:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // registroFechasMedia
            // 
            this.registroFechasMedia.AllowUserToAddRows = false;
            this.registroFechasMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroFechasMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_so,
            this.hotel_so,
            this.account_so});
            this.registroFechasMedia.Location = new System.Drawing.Point(28, 301);
            this.registroFechasMedia.Name = "registroFechasMedia";
            this.registroFechasMedia.Size = new System.Drawing.Size(403, 193);
            this.registroFechasMedia.TabIndex = 49;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Fecha:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(28, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Hotel:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // textFecha
            // 
            // 
            // 
            // 
            this.textFecha.CustomButton.Image = null;
            this.textFecha.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.textFecha.CustomButton.Name = "";
            this.textFecha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFecha.CustomButton.TabIndex = 1;
            this.textFecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFecha.CustomButton.UseSelectable = true;
            this.textFecha.CustomButton.Visible = false;
            this.textFecha.Lines = new string[0];
            this.textFecha.Location = new System.Drawing.Point(28, 98);
            this.textFecha.MaxLength = 32767;
            this.textFecha.Name = "textFecha";
            this.textFecha.PasswordChar = '\0';
            this.textFecha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFecha.SelectedText = "";
            this.textFecha.SelectionLength = 0;
            this.textFecha.SelectionStart = 0;
            this.textFecha.ShortcutsEnabled = true;
            this.textFecha.Size = new System.Drawing.Size(220, 23);
            this.textFecha.TabIndex = 45;
            this.textFecha.UseSelectable = true;
            this.textFecha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFecha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // programing
            // 
            this.programing.Location = new System.Drawing.Point(356, 500);
            this.programing.Name = "programing";
            this.programing.Size = new System.Drawing.Size(75, 23);
            this.programing.TabIndex = 44;
            this.programing.Text = "Programar";
            this.programing.UseSelectable = true;
            this.programing.Click += new System.EventHandler(this.programing_Click);
            // 
            // timer_banner_bdm
            // 
            this.timer_banner_bdm.Culture = new System.Globalization.CultureInfo("en-US");
            this.timer_banner_bdm.Location = new System.Drawing.Point(453, 76);
            this.timer_banner_bdm.Name = "timer_banner_bdm";
            this.timer_banner_bdm.Size = new System.Drawing.Size(532, 447);
            this.timer_banner_bdm.TabIndex = 43;
            this.timer_banner_bdm.Text = "sfCalendar1";
            this.timer_banner_bdm.DoubleClick += new System.EventHandler(this.timer_banner_bdm_DoubleClick);
            // 
            // account_text
            // 
            // 
            // 
            // 
            this.account_text.CustomButton.Image = null;
            this.account_text.CustomButton.Location = new System.Drawing.Point(381, 1);
            this.account_text.CustomButton.Name = "";
            this.account_text.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.account_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.account_text.CustomButton.TabIndex = 1;
            this.account_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.account_text.CustomButton.UseSelectable = true;
            this.account_text.CustomButton.Visible = false;
            this.account_text.Lines = new string[0];
            this.account_text.Location = new System.Drawing.Point(28, 218);
            this.account_text.MaxLength = 32767;
            this.account_text.Name = "account_text";
            this.account_text.PasswordChar = '\0';
            this.account_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.account_text.SelectedText = "";
            this.account_text.SelectionLength = 0;
            this.account_text.SelectionStart = 0;
            this.account_text.ShortcutsEnabled = true;
            this.account_text.Size = new System.Drawing.Size(403, 23);
            this.account_text.TabIndex = 54;
            this.account_text.UseSelectable = true;
            this.account_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.account_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 53;
            this.metroLabel3.Text = "Accout Manager:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // hotel_combo
            // 
            // 
            // 
            // 
            this.hotel_combo.CustomButton.Image = null;
            this.hotel_combo.CustomButton.Location = new System.Drawing.Point(381, 1);
            this.hotel_combo.CustomButton.Name = "";
            this.hotel_combo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hotel_combo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotel_combo.CustomButton.TabIndex = 1;
            this.hotel_combo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotel_combo.CustomButton.UseSelectable = true;
            this.hotel_combo.CustomButton.Visible = false;
            this.hotel_combo.Lines = new string[0];
            this.hotel_combo.Location = new System.Drawing.Point(28, 154);
            this.hotel_combo.MaxLength = 32767;
            this.hotel_combo.Name = "hotel_combo";
            this.hotel_combo.PasswordChar = '\0';
            this.hotel_combo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotel_combo.SelectedText = "";
            this.hotel_combo.SelectionLength = 0;
            this.hotel_combo.SelectionStart = 0;
            this.hotel_combo.ShortcutsEnabled = true;
            this.hotel_combo.Size = new System.Drawing.Size(403, 23);
            this.hotel_combo.TabIndex = 55;
            this.hotel_combo.UseSelectable = true;
            this.hotel_combo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotel_combo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fecha_so
            // 
            this.fecha_so.HeaderText = "Fecha";
            this.fecha_so.Name = "fecha_so";
            // 
            // hotel_so
            // 
            this.hotel_so.HeaderText = "Hotel";
            this.hotel_so.Name = "hotel_so";
            this.hotel_so.Width = 400;
            // 
            // account_so
            // 
            this.account_so.HeaderText = "Account";
            this.account_so.Name = "account_so";
            // 
            // take_over_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 546);
            this.Controls.Add(this.hotel_combo);
            this.Controls.Add(this.account_text);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.add);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.registroFechasMedia);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.programing);
            this.Controls.Add(this.timer_banner_bdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "take_over_bd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Take Over BD";
            this.Load += new System.EventHandler(this.take_over_bd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroFechasMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteRow;
        private MetroFramework.Controls.MetroButton add;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView registroFechasMedia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textFecha;
        private MetroFramework.Controls.MetroButton programing;
        private Syncfusion.WinForms.Input.SfCalendar timer_banner_bdm;
        private MetroFramework.Controls.MetroTextBox account_text;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox hotel_combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_so;
    }
}