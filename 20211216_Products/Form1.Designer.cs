
namespace _20211216_Products
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.variety_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.picture_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.variety_textbox = new System.Windows.Forms.TextBox();
            this.display_listbox = new System.Windows.Forms.ListBox();
            this.properties_combobox = new System.Windows.Forms.ComboBox();
            this.property_label = new System.Windows.Forms.Label();
            this.product_picturebox = new System.Windows.Forms.PictureBox();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.discount_checkbox = new System.Windows.Forms.CheckBox();
            this.stock_checkbox = new System.Windows.Forms.CheckBox();
            this.rating_textbox = new System.Windows.Forms.TextBox();
            this.picture_checkbox = new System.Windows.Forms.CheckBox();
            this.create_product_button = new System.Windows.Forms.Button();
            this.destroy_product_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_label.Location = new System.Drawing.Point(12, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(37, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Ad";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_label.Location = new System.Drawing.Point(12, 46);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(81, 25);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "Numara";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.type_label.Location = new System.Drawing.Point(12, 84);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(42, 25);
            this.type_label.TabIndex = 3;
            this.type_label.Text = "Tür";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price_label.Location = new System.Drawing.Point(12, 123);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(54, 25);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "Fiyat";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.discount_label.Location = new System.Drawing.Point(12, 156);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(118, 25);
            this.discount_label.TabIndex = 5;
            this.discount_label.Text = "Fırsat Ürünü";
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stock_label.Location = new System.Drawing.Point(12, 194);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(104, 25);
            this.stock_label.TabIndex = 6;
            this.stock_label.Text = "Stokta Var";
            // 
            // variety_label
            // 
            this.variety_label.AutoSize = true;
            this.variety_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.variety_label.Location = new System.Drawing.Point(12, 232);
            this.variety_label.Name = "variety_label";
            this.variety_label.Size = new System.Drawing.Size(115, 25);
            this.variety_label.TabIndex = 7;
            this.variety_label.Text = "Çeşit Sayısı";
            // 
            // rating_label
            // 
            this.rating_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rating_label.Location = new System.Drawing.Point(12, 268);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(140, 52);
            this.rating_label.TabIndex = 8;
            this.rating_label.Text = "Değerlendirme Puanı";
            // 
            // picture_label
            // 
            this.picture_label.AutoSize = true;
            this.picture_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.picture_label.Location = new System.Drawing.Point(12, 330);
            this.picture_label.Name = "picture_label";
            this.picture_label.Size = new System.Drawing.Size(102, 25);
            this.picture_label.TabIndex = 9;
            this.picture_label.Text = "Resmi Var";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(158, 13);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 22);
            this.name_textbox.TabIndex = 10;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(158, 50);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(100, 22);
            this.id_textbox.TabIndex = 11;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(158, 127);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(100, 22);
            this.price_textbox.TabIndex = 13;
            // 
            // variety_textbox
            // 
            this.variety_textbox.Location = new System.Drawing.Point(158, 236);
            this.variety_textbox.Name = "variety_textbox";
            this.variety_textbox.Size = new System.Drawing.Size(100, 22);
            this.variety_textbox.TabIndex = 15;
            // 
            // display_listbox
            // 
            this.display_listbox.FormattingEnabled = true;
            this.display_listbox.ItemHeight = 16;
            this.display_listbox.Location = new System.Drawing.Point(398, 9);
            this.display_listbox.Name = "display_listbox";
            this.display_listbox.Size = new System.Drawing.Size(291, 308);
            this.display_listbox.TabIndex = 18;
            this.display_listbox.SelectedIndexChanged += new System.EventHandler(this.display_listbox_SelectedIndexChanged);
            // 
            // properties_combobox
            // 
            this.properties_combobox.FormattingEnabled = true;
            this.properties_combobox.Items.AddRange(new object[] {
            "Lütfen bir özellik seçiniz",
            "Ad",
            "Numara",
            "Tür",
            "Fiyat",
            "Fırsat Ürünü",
            "Stokta Var",
            "Çeşit Sayısı",
            "Değerlendirme",
            "Resmi Var"});
            this.properties_combobox.Location = new System.Drawing.Point(398, 336);
            this.properties_combobox.Name = "properties_combobox";
            this.properties_combobox.Size = new System.Drawing.Size(187, 24);
            this.properties_combobox.TabIndex = 19;
            this.properties_combobox.SelectedIndexChanged += new System.EventHandler(this.properties_combobox_SelectedIndexChanged);
            // 
            // property_label
            // 
            this.property_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.property_label.Location = new System.Drawing.Point(398, 379);
            this.property_label.Name = "property_label";
            this.property_label.Size = new System.Drawing.Size(291, 39);
            this.property_label.TabIndex = 20;
            // 
            // product_picturebox
            // 
            this.product_picturebox.Location = new System.Drawing.Point(717, 9);
            this.product_picturebox.Name = "product_picturebox";
            this.product_picturebox.Size = new System.Drawing.Size(308, 308);
            this.product_picturebox.TabIndex = 21;
            this.product_picturebox.TabStop = false;
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Items.AddRange(new object[] {
            "Gıda",
            "Giyim",
            "Elektronik",
            "Kırtasiye",
            "Bakım",
            "Yayın",
            "Diğer"});
            this.type_combobox.Location = new System.Drawing.Point(158, 88);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(100, 24);
            this.type_combobox.TabIndex = 22;
            // 
            // discount_checkbox
            // 
            this.discount_checkbox.AutoSize = true;
            this.discount_checkbox.Location = new System.Drawing.Point(158, 164);
            this.discount_checkbox.Name = "discount_checkbox";
            this.discount_checkbox.Size = new System.Drawing.Size(18, 17);
            this.discount_checkbox.TabIndex = 23;
            this.discount_checkbox.UseVisualStyleBackColor = true;
            // 
            // stock_checkbox
            // 
            this.stock_checkbox.AutoSize = true;
            this.stock_checkbox.Location = new System.Drawing.Point(158, 202);
            this.stock_checkbox.Name = "stock_checkbox";
            this.stock_checkbox.Size = new System.Drawing.Size(18, 17);
            this.stock_checkbox.TabIndex = 24;
            this.stock_checkbox.UseVisualStyleBackColor = true;
            // 
            // rating_textbox
            // 
            this.rating_textbox.Location = new System.Drawing.Point(158, 286);
            this.rating_textbox.Name = "rating_textbox";
            this.rating_textbox.Size = new System.Drawing.Size(100, 22);
            this.rating_textbox.TabIndex = 25;
            // 
            // picture_checkbox
            // 
            this.picture_checkbox.AutoSize = true;
            this.picture_checkbox.Location = new System.Drawing.Point(156, 336);
            this.picture_checkbox.Name = "picture_checkbox";
            this.picture_checkbox.Size = new System.Drawing.Size(18, 17);
            this.picture_checkbox.TabIndex = 26;
            this.picture_checkbox.UseVisualStyleBackColor = true;
            // 
            // create_product_button
            // 
            this.create_product_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.create_product_button.Location = new System.Drawing.Point(17, 371);
            this.create_product_button.Name = "create_product_button";
            this.create_product_button.Size = new System.Drawing.Size(239, 47);
            this.create_product_button.TabIndex = 27;
            this.create_product_button.Text = "ÜRÜNÜ KAYDET";
            this.create_product_button.UseVisualStyleBackColor = true;
            this.create_product_button.Click += new System.EventHandler(this.create_product_button_Click);
            // 
            // destroy_product_button
            // 
            this.destroy_product_button.Location = new System.Drawing.Point(591, 337);
            this.destroy_product_button.Name = "destroy_product_button";
            this.destroy_product_button.Size = new System.Drawing.Size(98, 23);
            this.destroy_product_button.TabIndex = 28;
            this.destroy_product_button.Text = "Ürünü Sil";
            this.destroy_product_button.UseVisualStyleBackColor = true;
            this.destroy_product_button.Click += new System.EventHandler(this.destroy_product_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 432);
            this.Controls.Add(this.destroy_product_button);
            this.Controls.Add(this.create_product_button);
            this.Controls.Add(this.picture_checkbox);
            this.Controls.Add(this.rating_textbox);
            this.Controls.Add(this.stock_checkbox);
            this.Controls.Add(this.discount_checkbox);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.product_picturebox);
            this.Controls.Add(this.property_label);
            this.Controls.Add(this.properties_combobox);
            this.Controls.Add(this.display_listbox);
            this.Controls.Add(this.variety_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.picture_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.variety_label);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.product_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.Label variety_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label picture_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox variety_textbox;
        private System.Windows.Forms.ListBox display_listbox;
        private System.Windows.Forms.ComboBox properties_combobox;
        private System.Windows.Forms.Label property_label;
        private System.Windows.Forms.PictureBox product_picturebox;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.CheckBox discount_checkbox;
        private System.Windows.Forms.CheckBox stock_checkbox;
        private System.Windows.Forms.TextBox rating_textbox;
        private System.Windows.Forms.CheckBox picture_checkbox;
        private System.Windows.Forms.Button create_product_button;
        private System.Windows.Forms.Button destroy_product_button;
    }
}

