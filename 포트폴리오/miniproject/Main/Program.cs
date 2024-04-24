using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hansot_pos.FoodType;

namespace hansot_pos
{
    static class Program
    {
        //모든 메뉴 정보를 담은 리스트
        public static List<MenuInfo> menuList = new List<MenuInfo>()
        {
            new MenuInfo() { category = foodType.primeumGomei, Name = "매화(치킨, 연어구이)", price = 10000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "매화(순살 고등어데리야끼)", price = 10000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "진달래", price = 7000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "개나리(순살 고등어데리야끼)", price = 8000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "개나리(순살 고등어조림)", price = 8000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "큐브스테이크 필라프", price = 6300},
            new MenuInfo() { category = foodType.primeumGomei, Name = "나시고랭", price = 4500},
            new MenuInfo() { category = foodType.primeumGomei, Name = "순살 고등어조림", price = 6000},
            new MenuInfo() { category = foodType.primeumGomei, Name = "데미그라스 함박스테이크", price = 5800},
            new MenuInfo() { category = foodType.primeumGomei, Name = "깐깐도시락", price = 5800},
            new MenuInfo() { category = foodType.primeumGomei, Name = "깐풍기 도시락", price = 4300},
            new MenuInfo() { category = foodType.square, Name = "새치 고기고기", price = 6000},
            new MenuInfo() { category = foodType.square, Name = "돈치 고기고기", price = 5200},
            new MenuInfo() { category = foodType.square, Name = "고기고기", price = 3800},
            new MenuInfo() { category = foodType.square, Name = "동백", price = 5000},
            new MenuInfo() { category = foodType.square, Name = "돈치불고기", price = 4700},
            new MenuInfo() { category = foodType.square, Name = "치킨제육", price = 4300},
            new MenuInfo() { category = foodType.square, Name = "국화", price = 4000},
            new MenuInfo() { category = foodType.square, Name = "돈까스도련님", price = 3800},
            new MenuInfo() { category = foodType.square, Name = "제육볶음", price = 3700},
            new MenuInfo() { category = foodType.square, Name = "도련님", price = 3600},
            new MenuInfo() { category = foodType.bowl, Name = "왕치킨마요", price = 4200},
            new MenuInfo() { category = foodType.bowl, Name = "빅치킨마요", price = 3400},
            new MenuInfo() { category = foodType.bowl, Name = "돈치마요", price = 3400},
            new MenuInfo() { category = foodType.bowl, Name = "참치 샐러드마요", price = 3300},
            new MenuInfo() { category = foodType.bowl, Name = "치킨 샐러드마요", price = 3300},
            new MenuInfo() { category = foodType.bowl, Name = "치킨마요", price = 2800},
            new MenuInfo() { category = foodType.bowl, Name = "참치마요", price = 2800},
            new MenuInfo() { category = foodType.bowl, Name = "소불고기 카레", price = 4300},
            new MenuInfo() { category = foodType.bowl, Name = "돈까스 카레", price = 3900},
            new MenuInfo() { category = foodType.bowl, Name = "카레도시락", price = 2800},
            new MenuInfo() { category = foodType.bowl, Name = "소불고기 철판볶음밥", price = 4500},
            new MenuInfo() { category = foodType.bowl, Name = "한솥 철판볶음밥", price = 3700},
            new MenuInfo() { category = foodType.bowl, Name = "소고기 육개장", price = 4500},
            new MenuInfo() { category = foodType.bowl, Name = "묵은지 김치찌개", price = 4300},
            new MenuInfo() { category = foodType.bowl, Name = "소불고기 덮밥", price = 4200},
            new MenuInfo() { category = foodType.bowl, Name = "왕카레돈까스덮밥", price = 5500},
            new MenuInfo() { category = foodType.bowl, Name = "새우돈까스 덮밥", price = 3800},
            new MenuInfo() { category = foodType.bowl, Name = "돈까스 덮밥", price = 3600},
            new MenuInfo() { category = foodType.bowl, Name = "치즈 불닭비빔밥", price = 5500},
            new MenuInfo() { category = foodType.bowl, Name = "불닭비빔밥", price = 4500},
            new MenuInfo() { category = foodType.bowl, Name = "소불고기 감초고추장 비빔밥", price = 4800},
            new MenuInfo() { category = foodType.bowl, Name = "시골제육 두부강된장 비빔밥", price = 4800},
            new MenuInfo() { category = foodType.bowl, Name = "참치야채 감초고추장", price = 3200},
            new MenuInfo() { category = foodType.bowl, Name = "열무 두부강된장 비빔밥", price = 3800},
            new MenuInfo() { category = foodType.bowl, Name = "폴리도시락", price = 3800},
            new MenuInfo() { category = foodType.side, Name = "반찬 큐브스테이크", price = 4300},
            new MenuInfo() { category = foodType.side, Name = "반찬 묵은지김치찌개", price = 3900},
            new MenuInfo() { category = foodType.side, Name = "반찬 소고기육개장", price = 4000},
            new MenuInfo() { category = foodType.side, Name = "반찬 카레", price = 2400},
            new MenuInfo() { category = foodType.side, Name = "반찬 깐쇼칠리새우", price = 6000},
            new MenuInfo() { category = foodType.side, Name = "반찬 깐깐콤비", price = 4800},
            new MenuInfo() { category = foodType.side, Name = "반찬 데미함박스테이크", price = 4800},
            new MenuInfo() { category = foodType.side, Name = "반찬 소불고기", price = 3900},
            new MenuInfo() { category = foodType.side, Name = "반찬 순살 고등어데리야끼", price = 3400},
            new MenuInfo() { category = foodType.side, Name = "반찬 치킨", price = 3200},
            new MenuInfo() { category = foodType.side, Name = "반찬 깐풍기", price = 3000},
            new MenuInfo() { category = foodType.side, Name = "반찬 고기고기", price = 3000},
            new MenuInfo() { category = foodType.side, Name = "반찬 돈까스도련님", price = 3000},
            new MenuInfo() { category = foodType.side, Name = "반찬 제육볶음", price = 3000},
            new MenuInfo() { category = foodType.side, Name = "반찬 돈까스", price = 2500},
            new MenuInfo() { category = foodType.side, Name = "반찬 순살 고등어조림", price = 5000},
            new MenuInfo() { category = foodType.side, Name = "교자만두", price = 2800},
            new MenuInfo() { category = foodType.side, Name = "땅콩시나몬빠스", price = 1800},
            new MenuInfo() { category = foodType.side, Name = "케이준후라이", price = 1500},
            new MenuInfo() { category = foodType.side, Name = "치킨 샐러드(유자드레싱)", price = 3600},
            new MenuInfo() { category = foodType.side, Name = "치킨 샐러드(사과드레싱)", price = 3600},
            new MenuInfo() { category = foodType.side, Name = "그린 샐러드(유자드레싱)", price = 2900},
            new MenuInfo() { category = foodType.side, Name = "그린 샐러드(사과드레싱)", price = 2900},
            new MenuInfo() { category = foodType.side, Name = "미니 샐러드(유자드레싱)", price = 1500},
            new MenuInfo() { category = foodType.side, Name = "미니 샐러드(사과드레싱)", price = 1500},
            new MenuInfo() { category = foodType.side, Name = "닭강정(중)", price = 7000},
            new MenuInfo() { category = foodType.side, Name = "닭강정(소)", price = 2500},
            new MenuInfo() { category = foodType.side, Name = "치킨BOX(대)", price = 10000},
            new MenuInfo() { category = foodType.side, Name = "치킨BOX(중)_양식소스", price = 5000},
            new MenuInfo() { category = foodType.side, Name = "치킨BOX(중)_칠리소스", price = 5000},
            new MenuInfo() { category = foodType.side, Name = "치킨BOX(소)", price = 2500},
            new MenuInfo() { category = foodType.side, Name = "필라프", price = 2000},
            new MenuInfo() { category = foodType.side, Name = "영양밥", price = 2200},
            new MenuInfo() { category = foodType.side, Name = "현미밥", price = 1700},
            new MenuInfo() { category = foodType.side, Name = "한솥밥", price = 1000},
            new MenuInfo() { category = foodType.side, Name = "볶음김치", price = 400},
            new MenuInfo() { category = foodType.side, Name = "김치", price = 300},
            new MenuInfo() { category = foodType.side, Name = "무말랭이", price = 300},
            new MenuInfo() { category = foodType.primeumGomei, Name = "시그니처 도시락", price = 13000},
            new MenuInfo() { category = foodType.side, Name = "토마토 야채수프", price = 3000},
            new MenuInfo() { category = foodType.side, Name = "단호박 수프", price = 2500},
            new MenuInfo() { category = foodType.drink, Name = "펩시", price = 1500, barcodeString = 8801056070809.ToString()},
            new MenuInfo() { category = foodType.drink, Name = "코카콜라", price = 2000, barcodeString = 8801094017200.ToString()}
        };
        
        //테이블별 리스트
        public static List<MenuInfo> table1Menu = new List<MenuInfo>();
        public static List<MenuInfo> table2Menu = new List<MenuInfo>();
        public static List<MenuInfo> table3Menu = new List<MenuInfo>();
        public static List<MenuInfo> table4Menu = new List<MenuInfo>();
        public static List<MenuInfo> table5Menu = new List<MenuInfo>();
        public static List<MenuInfo> table6Menu = new List<MenuInfo>();

        public static List<MenuInfo> list = new List<MenuInfo>(); //임시 주문서

        public static List<MenuInfo> StatList = new List<MenuInfo>(); //통계 리스트

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
            Application.Run(new Main());
        }

        // 1. 테이블 화면 로딩시, 전체보기 클릭시에 5초 가량 걸림 -> process memory 너무 높음 -> 사진 용량을 줄였음에도 여전함.
        // 2. Loading시 Progress bar 가 순식간에 지나가고 끝남.
    }
}