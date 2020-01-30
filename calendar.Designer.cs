﻿namespace dashboard_medios
{
    partial class calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendar));
            this.calendar_full = new CalendarViewer.YearCalendarControl();
            this.destino_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.posicion_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // calendar_full
            // 
            this.calendar_full.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.calendar_full.Location = new System.Drawing.Point(38, 171);
            this.calendar_full.ModeYearLess = false;
            this.calendar_full.Name = "calendar_full";
            this.calendar_full.Size = new System.Drawing.Size(655, 420);
            this.calendar_full.TabIndex = 0;
            this.calendar_full.Text = "yearCalendarControl1";
            this.calendar_full.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            // 
            // destino_combo
            // 
            this.destino_combo.FormattingEnabled = true;
            this.destino_combo.ItemHeight = 23;
            this.destino_combo.Location = new System.Drawing.Point(99, 109);
            this.destino_combo.Name = "destino_combo";
            this.destino_combo.Size = new System.Drawing.Size(263, 29);
            this.destino_combo.TabIndex = 27;
            this.destino_combo.UseSelectable = true;
            this.destino_combo.SelectedIndexChanged += new System.EventHandler(this.destino_combo_SelectedIndexChanged_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Selecciona Destino:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // posicion_combo
            // 
            this.posicion_combo.FormattingEnabled = true;
            this.posicion_combo.ItemHeight = 23;
            this.posicion_combo.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera"});
            this.posicion_combo.Location = new System.Drawing.Point(368, 109);
            this.posicion_combo.Name = "posicion_combo";
            this.posicion_combo.Size = new System.Drawing.Size(263, 29);
            this.posicion_combo.TabIndex = 31;
            this.posicion_combo.UseSelectable = true;
            this.posicion_combo.SelectedIndexChanged += new System.EventHandler(this.posicion_combo_SelectedIndexChanged_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(368, 87);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Posición:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.posicion_combo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.destino_combo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.calendar_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calendar";
            this.Resizable = false;
            this.Text = "Calendario General de Medios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CalendarViewer.YearCalendarControl calendar_full;
        private MetroFramework.Controls.MetroComboBox destino_combo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox posicion_combo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}