namespace dashboard_medios
{
    partial class calendar_rdb_bd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendar_rdb_bd));
            this.posicion_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.destino_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.calendar_full = new CalendarViewer.YearCalendarControl();
            this.SuspendLayout();
            // 
            // posicion_combo
            // 
            this.posicion_combo.FormattingEnabled = true;
            this.posicion_combo.ItemHeight = 23;
            this.posicion_combo.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera"});
            this.posicion_combo.Location = new System.Drawing.Point(368, 99);
            this.posicion_combo.Name = "posicion_combo";
            this.posicion_combo.Size = new System.Drawing.Size(263, 29);
            this.posicion_combo.TabIndex = 36;
            this.posicion_combo.UseSelectable = true;
            this.posicion_combo.SelectedIndexChanged += new System.EventHandler(this.posicion_combo_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(368, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Posición:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // destino_combo
            // 
            this.destino_combo.FormattingEnabled = true;
            this.destino_combo.ItemHeight = 23;
            this.destino_combo.Location = new System.Drawing.Point(99, 99);
            this.destino_combo.Name = "destino_combo";
            this.destino_combo.Size = new System.Drawing.Size(263, 29);
            this.destino_combo.TabIndex = 34;
            this.destino_combo.UseSelectable = true;
            this.destino_combo.SelectedIndexChanged += new System.EventHandler(this.destino_combo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Selecciona Destino:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // calendar_full
            // 
            this.calendar_full.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.calendar_full.Location = new System.Drawing.Point(40, 134);
            this.calendar_full.ModeYearLess = false;
            this.calendar_full.Name = "calendar_full";
            this.calendar_full.Size = new System.Drawing.Size(655, 420);
            this.calendar_full.TabIndex = 37;
            this.calendar_full.Text = "yearCalendarControl1";
            this.calendar_full.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            // 
            // calendar_rdb_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 585);
            this.Controls.Add(this.calendar_full);
            this.Controls.Add(this.posicion_combo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.destino_combo);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calendar_rdb_bd";
            this.Resizable = false;
            this.Text = "Calendario RDB BD";
            this.Load += new System.EventHandler(this.calendar_rdb_bd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox posicion_combo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox destino_combo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private CalendarViewer.YearCalendarControl calendar_full;
    }
}