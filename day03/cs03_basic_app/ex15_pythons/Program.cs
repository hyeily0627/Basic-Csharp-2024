// 파이썬용 라이브러리 사용등록 
using IronPython.Hosting; 

namespace ex15_pythons
{
    /*
     ['', 'C:\\DEV\\Langs\\Python311\\python311.zip', 
    'C:\\DEV\\Langs\\Python311\\DLLs', 
    'C:\\DEV\\Langs\\Python311\\Lib', 
    'C:\\DEV\\Langs\\Python311', 
    'C:\\Users\\Administrator\\AppData\\Roaming\\Python\\Python311\\site-packages', 
    'C:\\Users\\Administrator\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32', 
    'C:\\Users\\Administrator\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32\\lib', 
    'C:\\Users\\Administrator\\AppData\\Roaming\\Python\\Python311\\site-packages\\Pythonwin', 
    'C:\\DEV\\Langs\\Python311\\Lib\\site-packages']
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("파이썬 실행 예제!");

            // 1. 파이썬 엔진 / 스코프 / 설정경로 생성 
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            // 2. Python 경로 설정 (@ : 리소스 키워드로 \\ 쓸 필요없이 \ 하나만 )
            paths.Add(@"C:\DEV\Langs\Python311");
            paths.Add(@"C:\DEV\Langs\Python311\DLLs");
            paths.Add(@"C:\DEV\Langs\Python311\Lib");

            paths.Add(@"C:\Users\Administrator\AppData\Roaming\Python\Python311\site-packages");
            paths.Add(@"C:\Users\Administrator\AppData\Roaming\Python\Python311\site-packages\win32");
            paths.Add(@"C:\Users\Administrator\AppData\Roaming\Python\Python311\site-packages\win32\lib");

            // 3. 실행시킬 파이썬 파일의 경로 설정
            var sourse = engine.CreateScriptSourceFromFile(@"C:\Sources\Basic-Csharp-2024\day03\cs03_basic_app\ex15_pythons\Text.py");

            // 4. 파이썬 실행
            sourse.Execute(scope);

            // 5. 해당 파이썬 함수를 Func 또는 Action으로 매핑 후, 매핑 시킨 메서드를 실행
            var PythonFunc = scope.GetVariable<Func<int, int, int>>("sum");
            Console.WriteLine($"파이썬 함수실행 = { PythonFunc(10, 7) }");

            var PythonGreeting = scope.GetVariable<Func<string>>("sayGreeting");
            var greeting = PythonGreeting();
            Console.WriteLine($"결과 = {greeting}");



        }
    }
}
