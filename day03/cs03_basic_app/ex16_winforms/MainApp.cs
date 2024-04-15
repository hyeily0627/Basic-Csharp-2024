using System;
using System.Windows.Forms;

namespace ex16_winforms
{
    internal class MainApp : Form            // 상속 
    {
        static void Main(string[] args)
        {
            MainApp form = (new MainApp());  // 새로운 객체 생성 

            form.Click += Form_Click;
            //form.Scroll += Form_Scroll;
            form.KeyPress += Form_KeyPress;

            Console.WriteLine("프로그램 시작");
            Application.Run(form);

            Console.WriteLine("프로그램 종료");
        }

        private static void Form_KeyPress(object? sender, KeyPressEventArgs e)
        {
            //Console.WriteLine("키보드 클릭!");  // 클릭시 해당 문구 출력 
            Console.WriteLine(e.KeyChar);         // 키보드 타자 친대로 출력 
        }

        /*
        //폼 스크롤 이벤트 핸들러
        private static void Form_Scroll(object? sender, ScrollEventArgs e)
        {
           Console.WriteLine("스크롤 발생!");
        }
        */

        // 폼 클릭 이벤트 핸들러
        private static void Form_Click(object? sender, EventArgs e)
        {
            Console.WriteLine("프로그램 종료중 ... "); 
            Application.Exit();
        }
        
        // 스크롤이랑 클릭이랑 충돌상황ㅎㅎ
    }
}
