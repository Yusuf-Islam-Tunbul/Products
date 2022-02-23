using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace _20211216_Products
{
    public partial class Form1 : Form
    {
        List<Product> products;
        List<String> properties;
        bool create_product;

        public Form1()
        {
            InitializeComponent();
            product_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            products = new List<Product>();
            properties = new List<string> { "Name", "Id", "Type", "Price", "Discount", "Stock", "Variety", "Rating", "Picture" };
            properties_combobox.SelectedIndex = 0;
            //MessageBox.Show(display_listbox.SelectedIndex.ToString());
        }

        private void create_product_button_Click(object sender, EventArgs e)
        {
            CreateProductMethod();
        }

        void CreateProductMethod()
        {
            Product product = new Product();
            create_product = true;

            SetProductNameMethod_(product);
            SetProductIdMethod_(product);
            SetProductTypeMethod_(product);
            SetProductPriceMethod_(product);
            SetProductDiscountMethod_(product);
            SetProductStockMethod_(product);
            SetProductVarietyMethod_(product);
            SetProductRatingMethod_(product);
            SetProductPictureMethod_(product);

            if (create_product)
            {
                products.Add(product);
                display_listbox.Items.Add(product.Name);
            }


        }



        void SetProductNameMethod_(Product product)
        {
            var data = name_textbox.Text;
            string name = data;

            if (products.Where(p => p.Name == name).Count() != 0)
            {
                MessageBox.Show("Bu isme sahip bir ürün zaten var.");
                create_product = false;
            }

            else
            {
                SetProductNameMethod(product, name);
            }


        }

        void SetProductIdMethod_(Product product)
        {
            var data = id_textbox.Text;



            if (data.Length < 6 || data.Length > 10)
            {
                MessageBox.Show("Lütfen numara için 6 ila 10 haneli bir numara giriniz");
                create_product = false;
            }

            else
            {
                try
                {
                    long id = Convert.ToInt64(data);

                    if (products.Where(p => p.Id == id).Count() != 0)
                    {
                        MessageBox.Show("Bu numaraya sahip bir ürün zaten var.");
                        create_product = false;
                    }

                    else
                    {
                        SetProductIdMethod(product, id);
                    }                    
                }

                catch (FormatException)
                {
                    MessageBox.Show("Lütfen numara için 6 ila 10 haneli bir numara giriniz");
                    create_product = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    create_product = false;
                }
            }
        }

        void SetProductTypeMethod_(Product product)
        {
            var data = type_combobox.SelectedItem;

            try
            {
                if (data != null)
                {
                    string type = data.ToString();
                    SetProductTypeMethod(product, type);
                }

                else
                {
                    MessageBox.Show("Lütfen bir tür seçiniz");
                    create_product = false;
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen bir tür seçiniz");
                create_product = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                create_product = false;
            }
        }

        void SetProductPriceMethod_(Product product)
        {
            var data = price_textbox.Text;

            try
            {
                double price = Convert.ToDouble(data);
                if (price <= 0)
                {
                    MessageBox.Show("Lütfen fiyat için sıfırdan büyük bir değer giriniz");
                    create_product = false;
                }

                else
                {
                    SetProductPriceMethod(product, price);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Lütfen fiyat için bir sayı giriniz.");
                create_product = false;
            }

            catch (OverflowException)
            {
                MessageBox.Show("Lütfen daha düşük bir fiyat giriniz.");
                create_product = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                create_product = false;
            }
        }

        void SetProductDiscountMethod_(Product product)
        {
            var data = discount_checkbox.Checked;
            bool discount = data;
            SetProductDiscountMethod(product, discount);
        }

        void SetProductStockMethod_(Product product)
        {
            var data = stock_checkbox.Checked;
            bool stock = data;
            SetProductDiscountMethod(product, stock);
        }

        void SetProductVarietyMethod_(Product product)
        {
            var data = variety_textbox.Text;

            try
            {
                int variety = Convert.ToInt32(data);

                if (variety < 1)
                {
                    MessageBox.Show("Lütfen çeşit sayısı için 1'den büyük bir tam sayı giriniz");
                    create_product = false;
                }

                else
                {
                    SetProductVarietyMethod(product, variety);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Lütfen çeşit sayısı için bir tam sayı giriniz");
                create_product = false;
            }

            catch (OverflowException)
            {
                MessageBox.Show("Lütfen çeşit için daha düşük bir sayı giriniz.");
                create_product = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SetProductRatingMethod_(Product product)
        {
            var data = rating_textbox.Text;

            try
            {
                double rating = Convert.ToDouble(data);

                if (rating < 0 || rating > 5)
                {
                    MessageBox.Show("Lütfen 0 ila 5 arasında bir puan giriniz.");
                    create_product = false;
                }

                else
                {
                    SetProductRatingMethod(product, rating);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Lütfen değerlendirme puanı için bir sayı giriniz.");
                create_product = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                create_product = false;
            }
        }

        void SetProductPictureMethod_(Product product)
        {
            var data = picture_checkbox.Checked;
            bool picture = data;
            SetProductPictureMethod(product, picture);
        }




        void SetProductNameMethod(Product product, string name)
        {
            product.Name = name;
        }

        void SetProductIdMethod(Product product, long id)
        {
            product.Id = id;
        }

        void SetProductTypeMethod(Product product, string type)
        {
            product.Type = type;
        }

        void SetProductPriceMethod(Product product, double price)
        {
            product.Price = price;
        }

        void SetProductDiscountMethod(Product product, bool discount)
        {
            product.Discount = discount;
        }

        void SetProductStockMethod(Product product, bool stock)
        {
            product.Stock = stock;
        }

        void SetProductVarietyMethod(Product product, int variety)
        {
            product.Variety = variety;
        }

        void SetProductRatingMethod(Product product, double rating)
        {
            product.Rating = rating;
        }

        void SetProductPictureMethod(Product product, bool picture)
        {
            product.Picture = picture;
        }

        void UpdateLabel()
        {

            int listbox_index = display_listbox.SelectedIndex;
            int combobox_index = properties_combobox.SelectedIndex;

            //MessageBox.Show(index.ToString());
            //MessageBox.Show(property_name);
            //MessageBox.Show(products[0].Type.ToString());

            if (listbox_index != -1 && combobox_index != -1 && combobox_index != 0)
            {
                string property_name = properties[combobox_index - 1].ToString();
                PropertyInfo bring_property = typeof(Product).GetProperty(property_name);
                property_label.Text = bring_property.GetValue(products[listbox_index], null).ToString();
            }

            //PropertyInfo bring_property = typeof(Product).GetProperty(property_name);
            //property_label.Text = bring_property.GetValue(products[index], null).ToString();
        }

        void UpdateImage()
        {
            int index = display_listbox.SelectedIndex;
            if (index != -1)
            {
                if (products[index].Picture)
                {
                    try
                    {
                        product_picturebox.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\" + products[display_listbox.SelectedIndex].Name.ToLower() + ".png");

                    }

                    catch (Exception)
                    {
                        product_picturebox.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\error2198479147921621696.png");
                    }
                }

                else
                {
                    product_picturebox.Image = null;
                }


            }
        }

        private void display_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
            UpdateImage();
        }

        private void properties_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void destroy_product_button_Click(object sender, EventArgs e)
        {
            DestroyProductMethod();
        }

        void DestroyProductMethod()
        {
            int index = display_listbox.SelectedIndex;

            if (display_listbox.Items.Count == 0)
            {
                MessageBox.Show("Liste boş.");
            }

            else if (index == -1)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz");                
            }

            else
            {
                DialogResult erase= MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "?", MessageBoxButtons.YesNo);
                if (erase==DialogResult.Yes)
                {
                    products.RemoveAt(index);
                    display_listbox.Items.RemoveAt(index);
                    product_picturebox.Image = null;
                    property_label.Text = "";
                }
            }
        }
    }
}
