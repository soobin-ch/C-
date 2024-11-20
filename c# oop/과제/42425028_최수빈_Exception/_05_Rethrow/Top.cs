using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rethrow
{
    internal class Top
    {


        public void SayHello()
        {
            try
            {
                string s = null;
                Console.WriteLine(s.ToString());  // NullReferenceException 발생
            }
            catch (Exception e)
            {
                Console.WriteLine("===2. Top 클래스의 SayHello() 내부\n");
                Console.WriteLine("---e.Message :"+ e.Message);  // 예외 메시지 출력
                Console.WriteLine("---e.ToString :"+ e.ToString());  // 예외 전체 정보 출력
                Console.WriteLine("---예외발생 장소 :"+ e.Source);  // 예외가 발생한 곳 출력
            }
        }
    }
}
