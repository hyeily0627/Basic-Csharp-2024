using System.Reflection;
using System.Reflection.Metadata;

namespace ex14_Attribute_Reflections
{

    class Myclass
    {

        [Obsolete("이 메서드는 다음버전에서 폐기됩니다. New Method를 사용하세요.")]
        /// <summary>
        /// 올드메서드는 다음과 같이 사용하세요
        /// </summary>
        public void OldMethod()
        {
            Console.WriteLine("OldMethod");

        }

        public void NewMethod() 
        {
            Console.WriteLine("NewMethod");
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 리플렉션 
            // 🚨리플렉션 - 잘 몰라도 됨 (GetType()만 기억해두기) 
            Console.WriteLine("리플렉션");

            int a = int.MaxValue;
            Type type = a.GetType();
            Console.WriteLine(type.FullName);   // 출력값 System.Int32

            float f = float.MaxValue;
            Console.WriteLine(f.GetType());     // 출력값 System.Single

            double d = float.MaxValue;
            Console.WriteLine(d.GetType());     // 출력값 System.double 


            FieldInfo[] fields = type.GetFields();    // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach(var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType}, Name : {item.Name}");
            }

            MethodInfo[] methods = type.GetMethods();    // 타입 객체에서 어떤 필드가 있는지 모두 확인
            foreach (var item in methods)
            {
                Console.WriteLine($"Type : {item.DeclaringType}, Name : {item.Name}");
            }

            #endregion

            // 🚨애트리뷰트 
            Console.WriteLine("애트리뷰트");

            Myclass myclass = new Myclass();    
            myclass.OldMethod();
        }
    }
}
