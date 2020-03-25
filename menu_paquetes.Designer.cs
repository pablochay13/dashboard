namespace dashboard_medios
{
    partial class menu_paquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_paquetes));
            this.list = new MetroFramework.Controls.MetroButton();
            this.program = new MetroFramework.Controls.MetroButton();
            this.calendar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(144, 101);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(115, 29);
            this.list.TabIndex = 5;
            this.list.Text = "Listar";
            this.list.UseSelectable = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(23, 101);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(115, 29);
            this.program.TabIndex = 4;
            this.program.Text = "Programar";
            this.program.UseSelectable = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(265, 101);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(115, 29);
            this.calendar.TabIndex = 11;
            this.calendar.Text = "Calendario";
            this.calendar.UseSelectable = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Best Day";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Liverpool";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(265, 186);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 29);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Calendario";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(144, 186);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(115, 29);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Listar";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 186);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(115, 29);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "Programar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // menu_paquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.list);
            this.Controls.Add(this.program);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menu_paquetes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Selecciona";
            this.Load += new System.EventHandler(this.menu_paquetes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton list;
        private MetroFramework.Controls.MetroButton program;
        private MetroFramework.Controls.MetroButton calendar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}