﻿namespace dashboard_medios
{
    partial class menu_take
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_take));
            this.list = new MetroFramework.Controls.MetroButton();
            this.program = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(145, 75);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(115, 29);
            this.list.TabIndex = 7;
            this.list.Text = "Listar";
            this.list.UseSelectable = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(24, 75);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(115, 29);
            this.program.TabIndex = 6;
            this.program.Text = "Programar";
            this.program.UseSelectable = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // take_over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 127);
            this.Controls.Add(this.list);
            this.Controls.Add(this.program);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "take_over";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Selecciona";
            this.Load += new System.EventHandler(this.take_over_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton list;
        private MetroFramework.Controls.MetroButton program;
    }
}