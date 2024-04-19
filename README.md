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
  - 이제는 신규 개발시, **.NET Framework** 사용하지 말 것! 

- 시작하기
  - Visual Studio 시작
  - 프로젝트 - 프로그램 개발 최소단위 그룹
  - **솔루션 - 프로젝트의 묶음**
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

- TIP🚨
  - 솔루션에서 오른쪽 버튼 > 속성 > 현재 선택 영역 체크 
  - 이렇게 해야 프로젝트 새로 생성할때 선택이 되어서 디버깅 혼선이 안생김

- TIP🚨 : F2 이름 바꾸기 

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
    - **C#에는 foreach**가 존재 -> 파이썬의 for item in []  과 동일
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
    public static void Divide (int a, int b, out int quotient, out int remainder)
    ``` 
    - 메서드 오버로딩(219p) : 여러 타입으로 같은 처리를 하는 메서드를 여러개 만들때
    ```cs
        public static int Plus(int a, int b)
      {
        return a + b;
      }

    public static float Plus(float a, float b) 
      {
        return a + b;
      }

    ``` 
    - 매개변수 가변길이(222p) : 매개변수 개수를 동적으로 처리할 때
    ```cs
        public static int Sum(params int[] argv)
      {
        int sum = 0;
        foreach (int item in argv)
        {
            sum += item;
        }
        return sum;
      }

    ``` 
    - 명명된 매개변수(224p) : 매개변수 값 미할당 시 기본값으로 지정
      ```cs
      public static void PrintProfile(string name, string phone)
      {
          Console.WriteLine($"이름 : {name}, 핸드폰 : {phone}");
      }

      PrintProfile(phone: "010-1234-5678", name: "홍길동"); // 매개변수 순서를 지정 가능
      ```

    - 기본값 매개변수 > 매개변수 값을 미할당 시 기본값 지정

      ```cs
      public static void DefaultMethod(int a = 1, int b = 0)
      {
          Console.WriteLine($"DefaultMethod = {a}, {b}");
      }
      DefaultMethod(10, 8); // a = 10, b = 8
      DefaultMethod(6); // a = 6, b = 0
      DefaultMethod(); // a = 1, b = 0

      ```      
  
- 클래스 
  - c++의 클래스, 객체와 유사(문법이 다소 상이)
  - 생성자는 new로 사용해서 객체 생성
  - 종료자는 C#에서 거의 사용안함
  - 생성자 오버로딩 -> 파라미터 개수에 따라서 사용가능, 기본적인 메서드 오버로딩하고 기능 동일
  - this 키워드 : this. (C++에서는 this->)

  - 접근 한정자
    - public : 클래스 내부/외부 접근 가능 
    - protected : 클래스 외부에서 접근 불가하며, 퍄생클래스에서는 접근 가능 (default)
    - private : 클래스 내부에서 접근 불가하며, 파생클래스에서는 접근 불가 
    - internal : 같은 어셈블리에 있는 코드에서만 public으로 접근 가능
    - protected internal : 같은 어셈블리에 있는 코드에서는 protected로 접근 가능 
    - private protected : 같은 어셈블리에 있는 클래스에서 상송받은 클래스 내부에서만 접근 할 수 있습니다. 
  - C#에는 다중상속은 없다 => C++ 다중상속으로 생기는 문제점을 해결하기 위해서 다중상속을 아예 없앰
    - 다중상속 해결 => 인터페이스 
    ```cs
    // 부모클래스 
    class BaseClass {

    }
    // 파생클래스(자식클래스)
    class DerivedClass : BaseClass{

    }
    ```

  - 구조체
    - 객체지향이 없었을 때, 좀 더 객체지향적인 프로그래밍을 위하여 만들어진 부분이다
    - class 이후로 사용빈도가 많이 줄어든 키워드 
    - 구조체는 스택(값형식). 클래스는 힙(참조형식)
    - C#에서는 구조체 안써도 됨

  - 튜플 (C# 7.0 이후 반영)
    - 한꺼번에 여러 개의 데이터를 리턴하거나 전달할 때 유용 
    - 값 할당 후 변경 불가

  - 인터페이스(315p) 
    - 클래스는 객체의 청사진, 인터페이스는 클래스의 청사진이다
    - 인터페이스는 클래스가 어떠한 메서드를 가져야하는지를 약속하는 것
    - 다중상속의 문제를 단일 상속으로도 해결하게 만든 주체
    - 인터페이스는 명명할때 제일 앞에 I를 적음 
    - 인터페이스의 메서드에는 구현을 작성하지 않음
    - 인터페이스는 약속
      - 클래스는 상속 시 별다른 문제 없으나, 인터페이스는 구현시 약속을 지키지 않으면 오류표시
    - 클래스는 '상속한다', 인터페이스는 '구현한다'
    - 인터페이스에서 약속한 메서드를 구현 안하면 빌드 불가! 
    ![인터페이스설명](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs001.png)

- 추상 클래스(abstract) 
  - Virtual method하고도 유사 
  - 추상 클래스를 단순화 시키면 인터페이스라 볼 수 있다
  
❗ Alt + Enter  - 로잘린 VS 개발 서포터
![단축키](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs002.png)
  - 오류 / 빈곳에서 사용 / 정상 구문에도 사용가능 

- **프로퍼티(340p)**
  - 클래스의 멤버변수 변형. 사용방법이 일반 변수와 유사함
  - 멤버변수의 접근제한자를 public으로 했을때 객체지향적 문제점(코드오염 등)을 해결하기 위해 사용
  - GET 접근자 / SET 접근자
  - SET은 값 할당시에 잘못된 데이터가 들어가지 않도록 막아야함 
  - JAVA에서 GETTER 메서드 / SETTET 메서드로 사용함 


## 2일차 
- TIP🚨
  - C# 빌드 시 오류 : 빌드 실행 후 실행창 안끄고 다시 빌드할 경우, 오류 발생(빌드 실패 경고창이 떠서 아니요 누르면 아래와 같이 오류 발생)
  ![빌드오류](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs003.png)
  - 1. 위 경우는 콘솔창이 떴기때문에 콘솔을 닫으면 되지만, 그렇지 않을 경우, (ctrl + shift + Esc)작업관리자 - 세부정보 - 해당 프로젝트 작업 끝내기 
  - 2. 재빌드 하기 

- 컬렉션(배열, 리스트, 인덱서)
  - 배열(375p) 
    - 모든 배열은 System.Array 클래스를 상속한 하위 클래스
    - 기본적인 배열의 사용법은 Pytion 리스트와도 동일하다
    - 배열 분할은 C# 8.0부터 적용 되었으며, 파이썬의 배열 슬라이스를 도입함
  - 컬렉션 : 파이썬의 리스트, 스택, 큐, 리스트와 동일
    - ArrayList
    - Stack
    - Queue
    - Hashtable(==Dictionary) 405p
  - foreach를 사용할 수 있는 객체로 만들기 - yield 

- 일반화(Generic) 프로그래밍(423p)
  - 파이썬 -> 변수에 제약사항 없음
  - 타입의 제약을 해소하고자 만든 기능 - ArrayList 등이 해결해줄 수 있지만, 박싱(언박싱)등의 성능문제가 있음
  - **하나의 타입으로 여러 타입의 처리를 해줄 수 있는 프로그래밍 방식** 
  - 일반화 컬렉션
    - List<T>
    - Stack<T>,Queue<T>
    - Dictionary<Tkey, Tvalue>

- 예외처리
  - 소스코드상 문법적 오류 -> 오류(Error)
  - 실행 중 생기는 오류 -> 예외(Exception)
  ```cs
  try
      {
      // ..예외가 발생할 것 같은 소스코드
      }
  catch(Exception ex) // 모든 예외클래스의 조상이 Exception이므로 어떤 예외코드를 써야하는지 모르겠으면 Exception 사용
      {
          Console.WriteLine(ex.Message);
      }
  finally
      {
          Console.WriteLine("프로그램 종료!")
      }
  ```

- '대리자'와 이벤트(494p) 
  - 메서드 호출시 매개변수 전달
  - 대리자 호출 시 함수(메서드) 자체를 전달
  - 이벤트 : 컴퓨터 내에서 발생하는 객체의 사건들(번개모양) 
  - 익명 메서드 사용 
  - delegate --> event 
  - 윈폼 개발 --> 이벤트(Event driven)프로그래밍 

- TIP🚨  
  - C# 주석 중 영역을 지정할 수 있음 => **#region ~ #endregion**
  ![영역접기전](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs004.png)
  ![영역접기후](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs005.png)

#region
#endregion

## 3일차 
- 람다식 : 익명 메서드를 만드는 방식 중에 하나 - delegate, lambda expression
  - 익명 메서드, 프로퍼티 사용시 코딩량을 줄여줌 
  - 대신 익명메서드 사용시 마다 대리자를 선언해야하기때문에 사용하는 Func와 Action 
    - Func와 Action 는 ms에서 미리 만들어둠

- LINQ((Language-INtegrated Query)) : 데이터 질의(Query) 기능을 C#에서 사용할 수 있는 기술로, C#의 배열, 컬렉션, XML, DataSet 등... 에서 내가 원하는 데이터만 가져오고 싶은 경우 사용할 수 있는 기술
  - DB SQL과 데이터 질의기능이 동일하다. 
  - 다른점 1번 : Group by에 집계함수가 필수가 아닌 것 외에는 SQL과 사용이 거의 동일
  - 다른점 2번 : 키워드 사용순서가 다른 것은 인지! 
  - LINQ만 고집하지 말고, 일반적인 C# 로직을 사용하는 방안도 항상 고려해두기

- 리플렉션 (Reflection) : 애플리케이션을 개발할 때, 디버깅 또는 런타임에 알 수 없는 객체의 동작을 분석하기 위해 사용하거나 외부 라이브러리에 존재하는 클래스 및 메서드를 분석하는 목적으로 사용

- 애트리뷰트 
  ```cs
  class MyClass
  {
      [Obsolete("OldMethod는 오래되었습니다. NewMethod()를 이용하십시오.")]
      public void OldMethod()
      {
          Console.WriteLine("old version...");
      }
      
      public void NewMethod()
      {
          Console.WriteLine("new version...");
      }
  }
  ```

- TIP🚨
  -  Summary 기능 
  -  클래스 상속, 생성 등을 통해 가져와서 쓰는데 저 메소드, 프로퍼티등이 뭐였지 할 때 설명가능함
  ![서머리](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs006.png)
  - **/// <summary> ///</summary> 사이에 메소드 설명 작성**
  - **///<param> ///</param> 사이에 파라미터 설명 작성** 


- dynamic 형식(파이썬 실행)
  - COM 객체 사용
  - IronPython 라이브러리 사용 : python을 C#에서 사용할 수 있도록 해주는 오픈소스 라이브러리
  - Nuget Package : 파이썬의 pip같은 라이브러리 관리툴
    - 1번 / 해당 프로젝트 > 종속성 > 마우스 오른쪽 버튼 > Nuget Package 관리 > 찾아보기 IronPython 검색 > 설치 
    - 2번(1번 안되는경우) / 도구 > Nuget Package 관리 > 패키지 관리자 콘솔 > 패키지소스 nuget.org , 기본프로젝트를 적용해야하는 것으로 설정 > Install-Package IronPython 입력
    1. 파이썬 엔진 / 스코프 / 설정경로 생성 
    2. 해당 컴퓨터 파이썬 경로들을 설정 
    3. 실행 시킬 파이썬 파일의 경로를 지정 
    4. 파이썬 실행(scope 연결) 
    5. 해당 파이썬 함수를 Func 또는 Action으로 매핑 후, 매핑 시킨 메서드를 실행 

- 가비지 컬렉션(GC : Garbage Collection)
  - C나 C++은 메모리 사용시 개발자가 직접 메모리 해제를 해야함
  - C#, JAVA, Python 등의 객체지향 언어는 Garbage Collection 기능으로 프로그램이 직접 관리
  - C#으로는 딱히 적용하거나, 실행 할 것이 없음! 

- Winform UI 개발 + (파일, 스레드)
  - 이벤트, 이벤트 핸들러 (대리자, 이벤트 연결)
  - 그래픽 사용자 인터페이스를 만드는 방법
  1. Winforms(Windows Forms) 
  2. WPF(Windows Presentation Foundation)
  - 위지위그(WYSIWYG: What You See Is What You Get, "보는 대로 얻는다") 방식의 GUI 프로그램 개발  
- Setting 
  - 새프로젝트 - C# / 모든 플랫폼 / 데스트톱 
  - 프로젝트 - 추가 - 웹에 양식 클릭 
  - 상단 도구상자 클릭해서 세팅 / F4 누르면 속성 
  - ❗Designer.cs는 웬만하면 건들지 말기(마우스로 세팅 가능한데 굳이 코드 건드릴 필요XX )


## 4일차
- Winform UI 개발 기본
  - Winforms 개발 학습 
  - 컨트롤 Prefix
    - ComboBox : Cbo
    - CheckBox : Chk
    - RadioButton : Rdo
    - TextBox : Txt 
    - Button : Btn
    - TrackBar : Trb
    - ProgressBar : Prg
    - TreeView : Trv
    - ListView : Lsv
    - PictureBox : Pic 
    - ~Dialog : Dlg
    - RichTextBox : Rtx


- 🚨주의 사항 및 참고 사항 
  - 속성 : Alt + Enter 
  - Ctrl + Shift + S 하면 켜져있는 모든 창 저장
  - ❗programs.cs도 건들지 않는다
  - 컨트롤 폼에 배치한 후에 더블클릭 금지!! -> 클릭 이벤트 들어가서 골아파짐 
  - 이벤트 생성 후, 삭제하고 싶으면 이벤트 창에서 이름 지우고 delete + enter(designer.cs에서 사라짐) -> Main.cs에서 내용 지우기
  - F6으로 빌드 실행하여 오류 없는 지 확인하고 Ctrl + F5 하기! 


## 5일차 
- Winform UI 개발 기본
  - 스레드 
    - 프로세스를 나누어서 동시에 여러가지 일을 진행 
    - 스레드 사용하기 불편함 
    - C# Backgroundwoker 클래스를 추가(스레드를 사용하기 편하게 만든 클래스)

  - 파일입출력
    - 리치텍스트박스(like MSWord, 한글 워드)로 파일저장 
    <img src="https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs007.png" width = 850>

  - 비동기 작업 앱
    - 가장 트렌드가 되는 작업방법
    - 백그라운드 처리는 Thread, BackgroundWorker와 유사
    - async, await 키워드 

    ![비동기앱](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs008.png)

  - 윈도우 참색기 앱 
  - 도서관리 앱 With SQL Server
  - ModernUI 앱 
  - 국가교통정보센터 CCTV 뷰 앱 
  - IoT Dummy 앱 with SQL Server 

## 6일차
- 토이 프로젝트
    - 윈도우 탐색기 앱(컨트롤학습)
      - MyExplorer 프로젝트 생성
      - 아이콘검색, png 2 ico 구글링 웹사이트
      - 트리뷰, 리스트뷰 기능 추가

      ![중간결과](https://raw.githubusercontent.com/hyeily0627/Basic-Csharp-2024/main/images/cs009.png)

      - 미적용 - 컨텍스트메뉴 보기 기능, 더블클릭 프로그램 실행, ...

## 7일차
- 토이 프로젝트
  - 윈도우 탐색기 앱 종료
    - 실행결과 
    https://github.com/hyeily0627/Basic-Csharp-2024/assets/156732476/20374d95-9ee9-47e6-9ef7-6dcd7038abbc

  - 도서관리 앱 with SQL Server(Base) ModernUI(NuGet패키지)


## 8일차 
- 토이 프로젝트
  - 도서관리 앱 종료 
  - IoT Dummy 앱 with SQL Server(IoT, DB)
  
    - 국가교통정보센터 CCTV뷰 앱(OpenAPI, NuGet dll, Network)