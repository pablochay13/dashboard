namespace dashboard_medios
{
    partial class menu_banner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_banner));
            this.program = new MetroFramework.Controls.MetroButton();
            this.list = new MetroFramework.Controls.MetroButton();
            this.calendar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(23, 75);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(115, 29);
            this.program.TabIndex = 0;
            this.program.Text = "Programar";
            this.program.UseSelectable = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(144, 75);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(115, 29);
            this.list.TabIndex = 1;
            this.list.Text = "Listar";
            this.list.UseSelectable = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(84, 110);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(115, 29);
            this.calendar.TabIndex = 11;
            this.calendar.Text = "Calendario";
            this.calendar.UseSelectable = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // menu_banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 163);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.list);
            this.Controls.Add(this.program);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menu_banner";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Selecciona";
            this.Load += new System.EventHandler(this.menu_banner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton program;
        private MetroFramework.Controls.MetroButton list;
        private MetroFramework.Controls.MetroButton calendar;
    }
}