namespace dashboard_medios
{
    partial class calendar_takeover_bd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendar_takeover_bd));
            this.calendar_full = new CalendarViewer.YearCalendarControl();
            this.SuspendLayout();
            // 
            // calendar_full
            // 
            this.calendar_full.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.calendar_full.Location = new System.Drawing.Point(38, 124);
            this.calendar_full.ModeYearLess = false;
            this.calendar_full.Name = "calendar_full";
            this.calendar_full.Size = new System.Drawing.Size(655, 420);
            this.calendar_full.TabIndex = 37;
            this.calendar_full.Text = "yearCalendarControl1";
            this.calendar_full.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            // 
            // calendar_takeover_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.calendar_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calendar_takeover_bd";
            this.Resizable = false;
            this.Text = "Calendario Take Over BD";
            this.Load += new System.EventHandler(this.calendar_takeover_bd_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CalendarViewer.YearCalendarControl calendar_full;
    }
}