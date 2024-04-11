# Basic-Csharp-2024
부경대학교 2024 IoT 개발자 과정 - c# 학습 리포지토리


# 1일차
- 프로그래밍 언어의 역사 
1. 프로그램의 시작 : 탄도계산을 위한 컴퓨터, 에니악
2. 포트란
3. 베이직(존 케머나, 토마스커츠) -> Visual Basic(마이크로소프트 빌게이츠)
4. 유닉스(AT&T 벨연구소 데니스 리치, 켄 톰슨) : B언어를 계승한 C언어 개발
5. C + 1 == C++(AT&T 벨연구소 비야네 스트롭스트룹)
6. C#(마이크로소프트 앤더스 헤일스버그<파스칼, 델파이 개발자>, 2000년도) 
  * C언어로 작성된 소스코드는 C++ 컴파일 할 수 있지만, C나 C++로 작성된 코드는 C# 에서 컴파일 불가함  
7. .NET 클래스 라이브러리

[프로그래밍 언어 순위] https://www.tiobe.com/tiobe-index/

- C#이란 ?
  - 객체지향 언어이며, C/C++ 및 JAVA를 참조해서 개발
  - 1995년 JAVA가 발표되면서, 경쟁을 위해 개발
  - OS플랫폼 독립적, 메모리 관리가 쉽다.
  - 다양한 분야에서 사용중
  - 2024년 Version 12 
  
- C# 사용분야
: 게임클라이언트, 고성능 서버, 데스크탑앱, IOT, 
Smart Factory, KIOSK, Mobile(MAUI)Android, IOS, Windows phone, Unity(Gameclient), SF, VR/AR 

* .NET Framework(CLR)
  - Window OS에 종속적
  - OS 독립적인 새로운 틀을 제작 하기 시작(2022년~) => .NET5.0
  - (24년 4월 기준) .NET 8.0
  - C/C++ Gcc 컴파일러, JAVA JDK, C# .NET5.0 이상 필요함
  - 이제는 신규 개발시, .NET Framework 사용하지 말 것! 

- 시작하기
  - Visual Basic 템플릿 설정 : C# / 모든 플랫폼 / 콘솔
    ```cs
    namespace hello_world // 프로그램 소스의 가장 큰 단위가 namespace == project 
    {
      internal class Program // 접근 제한자(private와 비슷). 구성 : 접근제한자 class 파일명 
      {
        static void Main(string[] args) // 정적 void Main - 모든 메서드의 첫번째 문자를 대문자로 쓰기로 약속
        {   
            // System 네임 스페이스 > Console 클래스에 있는 정적메서드 WriteLine()
            Console.WriteLine("Hello, World!");
        }
      }
    }
    ```

- 변수와 상수
    - C++과 동일하므로 PASS
    - 모든 C#의 객체는 object를 조상으로 함(68p)
    - 프로그램 메모리에는 스택(값형식, 정수, 실수...), 힙(참조형식, 클래스, 문자열, 리스트, 배열...)
    - boxing, unboxig(70p)
      ```cs
      int a 20;
      object b = a; // 박싱(object 박스에 담는다) -> 힙에 올리는 것 

      int c = (int) b; // 언박싱(object를 각 타입으로 변환)
      ```
    - 상수는 const 키워드 사용
    - var는 컴파일러가 자동으로 타입을 지정해주는 변수
 
- 연산자
    - C++과 동일!
    - ++, --가 파이썬에 없다는 것
    - and, or  = C++ / &&, || = C#
 
- 흐름제어
    - C++과 동일
    - if, switch, while, for, break, goto, continue 동일
    - C#에는 foreach가 존재 -> 파이썬의 for item in []  과 동일
      ```cs
      int[] arr = { 1, 2, 3, 4, 5 };
      
      foreach(var item in arr) 
      {
        Console.WriteLine($"현재 수 : {item}");            
      } 
      ```
- 메서드(Method)
    - C/C++ : 함수
    - JAVA, C++(객체지향언어) : 메서드
    - 파이썬(객체지향언어) : 함수
      
    - 매개변수 참조형식(211p) : C++애서 pointer로 값을 사용할 때와 동일한 기능
      ```cs
        static void Main(string[] args)
        {
            int x = 3 ; int y = 4;
            
            BasicSwap(x, y);
            Console.WriteLine($"x = {x}, y= {y}");

            RefSwap(ref x, ref y);
            Console.WriteLine($"x = {x}, y= {y}");
        }

        public static void BasicSwap(int a, int b) 
        {
            int temp = b;
            b = a;
            a = temp;   
        }
        
        public static void RefSwap(ref int a, ref int b)
        {
            int temp = b ;
            b = a;
            a = temp;
        }

      ```
      
    - 매개변수 출력형식(216p)
    ```cs
    ublic static void Divide (int a, int b, out int quotient, out int remainder)
    ``` 
    - 메서드 오버로딩 : 여러 타입으로 같은 처리를 하는 메서드를 여러개 만들때
    ```cs
    
    ``` 
    - 매개변수 가변길이 : 매개변수 개수를 동적으로 처리할 때
    ```cs
    
    ``` 
    - 명명된 매개변수 : 매개변수 값 미할당 시 기본값으로 지정
    ```cs
    
    ```      
  
