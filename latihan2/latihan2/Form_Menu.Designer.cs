namespace latihan2
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.item = new System.Windows.Forms.TabPage();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transaksi = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pilih = new System.Windows.Forms.ComboBox();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_tambah2 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.quanti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.TabPage();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.TabPage();
            this.keluar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.setting.SuspendLayout();
            this.logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.item);
            this.tabControl1.Controls.Add(this.transaksi);
            this.tabControl1.Controls.Add(this.setting);
            this.tabControl1.Controls.Add(this.logout);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("item.BackgroundImage")));
            this.item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.item.Controls.Add(this.dgv_item);
            this.item.Controls.Add(this.btn_hapus);
            this.item.Controls.Add(this.btn_edit);
            this.item.Controls.Add(this.btn_tambah);
            this.item.Controls.Add(this.btn_search);
            this.item.Controls.Add(this.textBox7);
            this.item.Controls.Add(this.textBox6);
            this.item.Controls.Add(this.textBox5);
            this.item.Controls.Add(this.textBox4);
            this.item.Controls.Add(this.textBox3);
            this.item.Controls.Add(this.textBox2);
            this.item.Controls.Add(this.textBox1);
            this.item.Controls.Add(this.label6);
            this.item.Controls.Add(this.label5);
            this.item.Controls.Add(this.label4);
            this.item.Controls.Add(this.label3);
            this.item.Controls.Add(this.label2);
            this.item.Controls.Add(this.label1);
            this.item.Location = new System.Drawing.Point(4, 29);
            this.item.Name = "item";
            this.item.Padding = new System.Windows.Forms.Padding(3);
            this.item.Size = new System.Drawing.Size(851, 491);
            this.item.TabIndex = 0;
            this.item.Text = "Items";
            // 
            // dgv_item
            // 
            this.dgv_item.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(6, 79);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.RowHeadersWidth = 62;
            this.dgv_item.RowTemplate.Height = 28;
            this.dgv_item.Size = new System.Drawing.Size(513, 309);
            this.dgv_item.TabIndex = 18;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(766, 411);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 35);
            this.btn_hapus.TabIndex = 17;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(662, 411);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 35);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(547, 411);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(83, 35);
            this.btn_tambah.TabIndex = 15;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(418, 411);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(101, 35);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Cari";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 411);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(371, 26);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(547, 362);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(288, 26);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(547, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(288, 26);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(547, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 26);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(547, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Per Satuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expired Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(543, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // transaksi
            // 
            this.transaksi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transaksi.BackgroundImage")));
            this.transaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transaksi.Controls.Add(this.label16);
            this.transaksi.Controls.Add(this.lbl_total);
            this.transaksi.Controls.Add(this.pilih);
            this.transaksi.Controls.Add(this.dgv_transaksi);
            this.transaksi.Controls.Add(this.btn_bayar);
            this.transaksi.Controls.Add(this.btn_reset);
            this.transaksi.Controls.Add(this.btn_tambah2);
            this.transaksi.Controls.Add(this.textBox10);
            this.transaksi.Controls.Add(this.quanti);
            this.transaksi.Controls.Add(this.label11);
            this.transaksi.Controls.Add(this.label10);
            this.transaksi.Controls.Add(this.label9);
            this.transaksi.Controls.Add(this.label8);
            this.transaksi.Controls.Add(this.label7);
            this.transaksi.Location = new System.Drawing.Point(4, 29);
            this.transaksi.Name = "transaksi";
            this.transaksi.Padding = new System.Windows.Forms.Padding(3);
            this.transaksi.Size = new System.Drawing.Size(851, 491);
            this.transaksi.TabIndex = 1;
            this.transaksi.Text = "Transactions";
            this.transaksi.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(727, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Rp. 0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(723, 83);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(47, 20);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Rp. 0";
            // 
            // pilih
            // 
            this.pilih.FormattingEnabled = true;
            this.pilih.Location = new System.Drawing.Point(23, 327);
            this.pilih.Name = "pilih";
            this.pilih.Size = new System.Drawing.Size(425, 28);
            this.pilih.TabIndex = 16;
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Location = new System.Drawing.Point(23, 83);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.RowHeadersWidth = 62;
            this.dgv_transaksi.RowTemplate.Height = 28;
            this.dgv_transaksi.Size = new System.Drawing.Size(556, 207);
            this.dgv_transaksi.TabIndex = 15;
            // 
            // btn_bayar
            // 
            this.btn_bayar.Location = new System.Drawing.Point(607, 190);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(220, 46);
            this.btn_bayar.TabIndex = 14;
            this.btn_bayar.Text = "Bayar";
            this.btn_bayar.UseVisualStyleBackColor = true;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(167, 427);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 36);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_tambah2
            // 
            this.btn_tambah2.Location = new System.Drawing.Point(31, 427);
            this.btn_tambah2.Name = "btn_tambah2";
            this.btn_tambah2.Size = new System.Drawing.Size(85, 36);
            this.btn_tambah2.TabIndex = 12;
            this.btn_tambah2.Text = "Tambah";
            this.btn_tambah2.UseVisualStyleBackColor = true;
            this.btn_tambah2.Click += new System.EventHandler(this.btn_tambah2_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(607, 107);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(220, 26);
            this.textBox10.TabIndex = 9;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // quanti
            // 
            this.quanti.Location = new System.Drawing.Point(23, 381);
            this.quanti.Name = "quanti";
            this.quanti.Size = new System.Drawing.Size(425, 26);
            this.quanti.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quantitas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pilih Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kembalian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Keranjang";
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.Transparent;
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.Controls.Add(this.pass);
            this.setting.Controls.Add(this.user);
            this.setting.Controls.Add(this.alamat);
            this.setting.Controls.Add(this.nama);
            this.setting.Controls.Add(this.label15);
            this.setting.Controls.Add(this.label14);
            this.setting.Controls.Add(this.label13);
            this.setting.Controls.Add(this.label12);
            this.setting.Controls.Add(this.btn_update);
            this.setting.Location = new System.Drawing.Point(4, 29);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(3);
            this.setting.Size = new System.Drawing.Size(851, 491);
            this.setting.TabIndex = 2;
            this.setting.Text = "Settings";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(30, 331);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(384, 26);
            this.pass.TabIndex = 8;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(30, 267);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(384, 26);
            this.user.TabIndex = 7;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(30, 175);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(384, 49);
            this.alamat.TabIndex = 6;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(30, 113);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(384, 26);
            this.nama.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Alamat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nama";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(647, 418);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(161, 38);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Save Change";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Controls.Add(this.keluar);
            this.logout.Location = new System.Drawing.Point(4, 29);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(3);
            this.logout.Size = new System.Drawing.Size(851, 491);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(359, 218);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(102, 38);
            this.keluar.TabIndex = 0;
            this.keluar.Text = "Logout";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.item.ResumeLayout(false);
            this.item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.transaksi.ResumeLayout(false);
            this.transaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            this.logout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage item;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage transaksi;
        private System.Windows.Forms.TabPage setting;
        private System.Windows.Forms.TabPage logout;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_bayar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_tambah2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox quanti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.ComboBox pilih;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label16;
    }
}