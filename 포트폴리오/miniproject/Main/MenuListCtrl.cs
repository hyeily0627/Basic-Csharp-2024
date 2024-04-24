using System;
using System.Drawing;
using System.Windows.Forms;

namespace hansot_pos
{
    public partial class MenuListCtrl : UserControl
    {
        //public delegate void MenuClickHander(object sender, EventArgs args);
        public event EventHandler OnMenuClick;

        private MenuInfo menuInfo = new MenuInfo();

        public MenuListCtrl(MenuInfo menuList)
        {
            InitializeComponent();
            SetData(menuList);
        }

        private void SetData(MenuInfo menuList)
        {
            menuInfo = menuList;

            //이미지 Path 문법 찾아보기.
            MenuImage.Image = new Bitmap(ImageResize(menuList.imagePath));
            MenuNameLabel.Text = menuList.Name;
            MenuPriceLabel.Text = Convert.ToString(menuList.price)+" 원";
        }

        private Bitmap ImageResize(string imagePath)
        {
            Bitmap originalImage = new Bitmap(imagePath);

            int width = originalImage.Width / 4;
            int height = originalImage.Height / 4;

            Size resize = new Size(width, height);
            Bitmap resizeImage = new Bitmap(originalImage, resize);

            return resizeImage;
        }

        private void MenuImage_Click(object sender, EventArgs e)
        {
            if (OnMenuClick != null)
            {
                OnMenuClick(this, null);
            }
        }

        public MenuInfo GetData()
        {
            return menuInfo;
        }
    }
}
