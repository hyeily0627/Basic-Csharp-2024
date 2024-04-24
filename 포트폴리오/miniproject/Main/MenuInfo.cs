
using static hansot_pos.FoodType;

namespace hansot_pos
{
    public class MenuInfo
    {
        public foodType category = foodType.none; //premium, bowl 등등
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                imagePath = SetImagePath(category, name);
            }
        }
        public int price = 0; //메뉴 가격
        public int cnt = 0; // 메뉴 주문 수량
        public string imagePath = string.Empty; //메뉴 이미지 링크
        public string barcodeString = string.Empty;

        //ImagePath 설정하고 return 해주는 함수
        public string SetImagePath(foodType category, string name)
        {
            string path = string.Empty;
            string RootPath = "Resources/MenuList/";
            
            switch(category)
            {
                case foodType.primeumGomei:
                    RootPath += "primeumGomei/";
                    break;

                case foodType.square:
                    RootPath += "square/";
                    break;

                case foodType.bowl:
                    RootPath += "bowl/";
                    break;

                case foodType.side:
                    RootPath += "side/";
                    break;

                case foodType.drink:
                    RootPath += "drink/";
                    break;

                default:
                    break;
            }

            path = RootPath + name + ".jpg";

            return path;
        }
    }
}
