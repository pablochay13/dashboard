namespace dashboard_medios
{
    partial class timer_banner_bd_full
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timer_banner_bd_full));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.check_account = new MetroFramework.Controls.MetroCheckBox();
            this.account_text = new MetroFramework.Controls.MetroTextBox();
            this.check_hotel = new MetroFramework.Controls.MetroCheckBox();
            this.cbFechas = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.fechaHasta = new MetroFramework.Controls.MetroDateTime();
            this.fechaDesde = new MetroFramework.Controls.MetroDateTime();
            this.filter = new MetroFramework.Controls.MetroButton();
            this.delete = new MetroFramework.Controls.MetroButton();
            this.export = new MetroFramework.Controls.MetroButton();
            this.registros = new MetroFramework.Controls.MetroGrid();
            this.id_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_combo = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registros)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.hotel_combo);
            this.metroPanel1.Controls.Add(this.check_account);
            this.metroPanel1.Controls.Add(this.account_text);
            this.metroPanel1.Controls.Add(this.check_hotel);
            this.metroPanel1.Controls.Add(this.cbFechas);
            this.metroPanel1.Controls.Add(this.metroLabel48);
            this.metroPanel1.Controls.Add(this.fechaHasta);
            this.metroPanel1.Controls.Add(this.fechaDesde);
            this.metroPanel1.Controls.Add(this.filter);
            this.metroPanel1.Controls.Add(this.delete);
            this.metroPanel1.Controls.Add(this.export);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(266, 399);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // check_account
            // 
            this.check_account.AutoSize = true;
            this.check_account.Location = new System.Drawing.Point(12, 135);
            this.check_account.Name = "check_account";
            this.check_account.Size = new System.Drawing.Size(121, 15);
            this.check_account.TabIndex = 47;
            this.check_account.Text = "Account Manager:";
            this.check_account.UseSelectable = true;
            // 
            // account_text
            // 
            // 
            // 
            // 
            this.account_text.CustomButton.Image = null;
            this.account_text.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.account_text.CustomButton.Name = "";
            this.account_text.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.account_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.account_text.CustomButton.TabIndex = 1;
            this.account_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.account_text.CustomButton.UseSelectable = true;
            this.account_text.CustomButton.Visible = false;
            this.account_text.Lines = new string[0];
            this.account_text.Location = new System.Drawing.Point(12, 156);
            this.account_text.MaxLength = 32767;
            this.account_text.Name = "account_text";
            this.account_text.PasswordChar = '\0';
            this.account_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.account_text.SelectedText = "";
            this.account_text.SelectionLength = 0;
            this.account_text.SelectionStart = 0;
            this.account_text.ShortcutsEnabled = true;
            this.account_text.Size = new System.Drawing.Size(241, 23);
            this.account_text.TabIndex = 46;
            this.account_text.UseSelectable = true;
            this.account_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.account_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // check_hotel
            // 
            this.check_hotel.AutoSize = true;
            this.check_hotel.Location = new System.Drawing.Point(12, 72);
            this.check_hotel.Name = "check_hotel";
            this.check_hotel.Size = new System.Drawing.Size(55, 15);
            this.check_hotel.TabIndex = 44;
            this.check_hotel.Text = "Hotel:";
            this.check_hotel.UseSelectable = true;
            // 
            // cbFechas
            // 
            this.cbFechas.AutoSize = true;
            this.cbFechas.Location = new System.Drawing.Point(12, 8);
            this.cbFechas.Name = "cbFechas";
            this.cbFechas.Size = new System.Drawing.Size(115, 15);
            this.cbFechas.TabIndex = 41;
            this.cbFechas.Text = "Rango de Fechas:";
            this.cbFechas.UseSelectable = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(119, 39);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(16, 19);
            this.metroLabel48.TabIndex = 16;
            this.metroLabel48.Text = "a";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHasta.Location = new System.Drawing.Point(141, 29);
            this.fechaHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(112, 29);
            this.fechaHasta.TabIndex = 15;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesde.Location = new System.Drawing.Point(12, 29);
            this.fechaDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(101, 29);
            this.fechaDesde.TabIndex = 14;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(69, 338);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(112, 23);
            this.filter.TabIndex = 12;
            this.filter.Text = "Filtrar";
            this.filter.UseSelectable = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(14, 367);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "Eliminar Registro";
            this.delete.UseSelectable = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(131, 367);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(112, 23);
            this.export.TabIndex = 10;
            this.export.Text = "Exportat a Excel";
            this.export.UseSelectable = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // registros
            // 
            this.registros.AllowUserToAddRows = false;
            this.registros.AllowUserToResizeRows = false;
            this.registros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.registros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_so,
            this.fecha_inicio,
            this.hotel,
            this.account});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registros.DefaultCellStyle = dataGridViewCellStyle2;
            this.registros.EnableHeadersVisualStyles = false;
            this.registros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registros.Location = new System.Drawing.Point(295, 80);
            this.registros.Name = "registros";
            this.registros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.registros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.registros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registros.Size = new System.Drawing.Size(646, 399);
            this.registros.TabIndex = 8;
            // 
            // id_so
            // 
            this.id_so.HeaderText = "ID";
            this.id_so.Name = "id_so";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.HeaderText = "Fecha";
            this.fecha_inicio.Name = "fecha_inicio";
            // 
            // hotel
            // 
            this.hotel.HeaderText = "Hotel";
            this.hotel.Name = "hotel";
            // 
            // account
            // 
            this.account.HeaderText = "Account";
            this.account.Name = "account";
            // 
            // hotel_combo
            // 
            // 
            // 
            // 
            this.hotel_combo.CustomButton.Image = null;
            this.hotel_combo.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.hotel_combo.CustomButton.Name = "";
            this.hotel_combo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hotel_combo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotel_combo.CustomButton.TabIndex = 1;
            this.hotel_combo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotel_combo.CustomButton.UseSelectable = true;
            this.hotel_combo.CustomButton.Visible = false;
            this.hotel_combo.Lines = new string[0];
            this.hotel_combo.Location = new System.Drawing.Point(12, 93);
            this.hotel_combo.MaxLength = 32767;
            this.hotel_combo.Name = "hotel_combo";
            this.hotel_combo.PasswordChar = '\0';
            this.hotel_combo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotel_combo.SelectedText = "";
            this.hotel_combo.SelectionLength = 0;
            this.hotel_combo.SelectionStart = 0;
            this.hotel_combo.ShortcutsEnabled = true;
            this.hotel_combo.Size = new System.Drawing.Size(241, 23);
            this.hotel_combo.TabIndex = 48;
            this.hotel_combo.UseSelectable = true;
            this.hotel_combo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotel_combo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timer_banner_bd_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 502);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.registros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "timer_banner_bd_full";
            this.Resizable = false;
            this.Text = "Lista Timer Banner BD";
            this.Load += new System.EventHandler(this.timer_banner_bd_full_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox check_account;
        private MetroFramework.Controls.MetroTextBox account_text;
        private MetroFramework.Controls.MetroCheckBox check_hotel;
        private MetroFramework.Controls.MetroCheckBox cbFechas;
        private MetroFramework.Controls.MetroLabel metroLabel48;
        private MetroFramework.Controls.MetroDateTime fechaHasta;
        private MetroFramework.Controls.MetroDateTime fechaDesde;
        private MetroFramework.Controls.MetroButton filter;
        private MetroFramework.Controls.MetroButton delete;
        private MetroFramework.Controls.MetroButton export;
        private MetroFramework.Controls.MetroGrid registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private MetroFramework.Controls.MetroTextBox hotel_combo;
    }
}