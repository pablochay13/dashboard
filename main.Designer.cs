namespace dashboard_medios
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.info_notes = new System.Windows.Forms.PictureBox();
            this.so_paquetes = new MetroFramework.Controls.MetroTile();
            this.settings = new MetroFramework.Controls.MetroTile();
            this.Users = new MetroFramework.Controls.MetroTile();
            this.inventorty = new MetroFramework.Controls.MetroTile();
            this.take_over = new MetroFramework.Controls.MetroTile();
            this.banner_rdb = new MetroFramework.Controls.MetroTile();
            this.timer_baner = new MetroFramework.Controls.MetroTile();
            this.sort_order = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.info_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // info_notes
            // 
            this.info_notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_notes.Image = global::dashboard_medios.Properties.Resources.notepad;
            this.info_notes.Location = new System.Drawing.Point(569, 24);
            this.info_notes.Name = "info_notes";
            this.info_notes.Size = new System.Drawing.Size(36, 36);
            this.info_notes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info_notes.TabIndex = 9;
            this.info_notes.TabStop = false;
            this.info_notes.Click += new System.EventHandler(this.info_notes_Click);
            // 
            // so_paquetes
            // 
            this.so_paquetes.ActiveControl = null;
            this.so_paquetes.Location = new System.Drawing.Point(173, 81);
            this.so_paquetes.Name = "so_paquetes";
            this.so_paquetes.Size = new System.Drawing.Size(140, 140);
            this.so_paquetes.Style = MetroFramework.MetroColorStyle.Lime;
            this.so_paquetes.TabIndex = 8;
            this.so_paquetes.Text = "Sort Orders Paquetes";
            this.so_paquetes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.so_paquetes.TileImage = global::dashboard_medios.Properties.Resources.sort;
            this.so_paquetes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.so_paquetes.UseSelectable = true;
            this.so_paquetes.UseTileImage = true;
            this.so_paquetes.Click += new System.EventHandler(this.so_paquetes_Click);
            // 
            // settings
            // 
            this.settings.ActiveControl = null;
            this.settings.Location = new System.Drawing.Point(465, 227);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(140, 140);
            this.settings.Style = MetroFramework.MetroColorStyle.Teal;
            this.settings.TabIndex = 7;
            this.settings.Text = "Ajustes";
            this.settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settings.TileImage = global::dashboard_medios.Properties.Resources.settings;
            this.settings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings.UseSelectable = true;
            this.settings.UseTileImage = true;
            // 
            // Users
            // 
            this.Users.ActiveControl = null;
            this.Users.Location = new System.Drawing.Point(319, 227);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(140, 140);
            this.Users.Style = MetroFramework.MetroColorStyle.Brown;
            this.Users.TabIndex = 6;
            this.Users.Text = "Usuarios";
            this.Users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Users.TileImage = global::dashboard_medios.Properties.Resources.users;
            this.Users.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Users.UseSelectable = true;
            this.Users.UseTileImage = true;
            // 
            // inventorty
            // 
            this.inventorty.ActiveControl = null;
            this.inventorty.Location = new System.Drawing.Point(173, 227);
            this.inventorty.Name = "inventorty";
            this.inventorty.Size = new System.Drawing.Size(140, 140);
            this.inventorty.Style = MetroFramework.MetroColorStyle.Orange;
            this.inventorty.TabIndex = 5;
            this.inventorty.Text = "Inventarios";
            this.inventorty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventorty.TileImage = global::dashboard_medios.Properties.Resources.inventario;
            this.inventorty.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inventorty.UseSelectable = true;
            this.inventorty.UseTileImage = true;
            // 
            // take_over
            // 
            this.take_over.ActiveControl = null;
            this.take_over.Location = new System.Drawing.Point(27, 227);
            this.take_over.Name = "take_over";
            this.take_over.Size = new System.Drawing.Size(140, 140);
            this.take_over.Style = MetroFramework.MetroColorStyle.Pink;
            this.take_over.TabIndex = 4;
            this.take_over.Text = "Taker Over";
            this.take_over.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.take_over.TileImage = global::dashboard_medios.Properties.Resources.take;
            this.take_over.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.take_over.UseSelectable = true;
            this.take_over.UseTileImage = true;
            this.take_over.Click += new System.EventHandler(this.take_over_Click);
            // 
            // banner_rdb
            // 
            this.banner_rdb.ActiveControl = null;
            this.banner_rdb.Location = new System.Drawing.Point(465, 81);
            this.banner_rdb.Name = "banner_rdb";
            this.banner_rdb.Size = new System.Drawing.Size(140, 140);
            this.banner_rdb.Style = MetroFramework.MetroColorStyle.Magenta;
            this.banner_rdb.TabIndex = 3;
            this.banner_rdb.Text = "Banners RDB";
            this.banner_rdb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.banner_rdb.TileImage = global::dashboard_medios.Properties.Resources.resultado;
            this.banner_rdb.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.banner_rdb.UseSelectable = true;
            this.banner_rdb.UseTileImage = true;
            this.banner_rdb.Click += new System.EventHandler(this.banner_rdb_Click);
            // 
            // timer_baner
            // 
            this.timer_baner.ActiveControl = null;
            this.timer_baner.Location = new System.Drawing.Point(319, 81);
            this.timer_baner.Name = "timer_baner";
            this.timer_baner.Size = new System.Drawing.Size(140, 140);
            this.timer_baner.Style = MetroFramework.MetroColorStyle.Red;
            this.timer_baner.TabIndex = 1;
            this.timer_baner.Text = "Timer Banner";
            this.timer_baner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.timer_baner.TileImage = global::dashboard_medios.Properties.Resources.timer;
            this.timer_baner.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer_baner.UseSelectable = true;
            this.timer_baner.UseTileImage = true;
            this.timer_baner.Click += new System.EventHandler(this.timer_baner_Click);
            // 
            // sort_order
            // 
            this.sort_order.ActiveControl = null;
            this.sort_order.Location = new System.Drawing.Point(27, 81);
            this.sort_order.Name = "sort_order";
            this.sort_order.Size = new System.Drawing.Size(140, 140);
            this.sort_order.TabIndex = 0;
            this.sort_order.Text = "Sort Orders Hoteles";
            this.sort_order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sort_order.TileImage = global::dashboard_medios.Properties.Resources.sort;
            this.sort_order.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sort_order.UseSelectable = true;
            this.sort_order.UseTileImage = true;
            this.sort_order.Click += new System.EventHandler(this.sort_order_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 413);
            this.Controls.Add(this.info_notes);
            this.Controls.Add(this.so_paquetes);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.inventorty);
            this.Controls.Add(this.take_over);
            this.Controls.Add(this.banner_rdb);
            this.Controls.Add(this.timer_baner);
            this.Controls.Add(this.sort_order);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Resizable = false;
            this.Text = "Control de Medios Best Travel Media";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info_notes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile sort_order;
        private MetroFramework.Controls.MetroTile timer_baner;
        private MetroFramework.Controls.MetroTile banner_rdb;
        private MetroFramework.Controls.MetroTile settings;
        private MetroFramework.Controls.MetroTile Users;
        private MetroFramework.Controls.MetroTile inventorty;
        private MetroFramework.Controls.MetroTile take_over;
        private MetroFramework.Controls.MetroTile so_paquetes;
        private System.Windows.Forms.PictureBox info_notes;
    }
}