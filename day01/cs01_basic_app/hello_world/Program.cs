﻿namespace hello_world // 프로그램 소스의 가장 큰 단위가 namespace == project 
{
    internal class Program // 접근 제한자(private와 비슷). 구성 : 접근제한자 class 파일명 
    {
        static void Main(string[] args) // 정적 void Main - 모든 메서드의 첫번째 문자를 대문자로 쓰기로 약속
        {   
            // System 네임 스페이스 > Console 클래스에 있는 정적메서드 WriteLine()
            //Console.WriteLine("Hello, World!");
            if (args.Length == 0) 
            {
                Console.WriteLine("사용법 : hello_world.exe <이름>"); 
                return;
            } else 
            { 
                Console.WriteLine($"Hello world: {args[0]}");
            }
        }
    }
}

