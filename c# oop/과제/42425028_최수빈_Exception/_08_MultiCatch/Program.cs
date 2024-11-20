using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MultiCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("어떤 종류의 얘외를 경험하시겠습니까");

            Console.WriteLine("\n1.DivideByZeroException | 2.IndexOutOfRangeException | 3. NullReferenceException | ^C Exit");

            while ((input = Console.ReadLine()) != null)
            {

                try
                {
                    switch (input)
                    {
                        case "1":
                            int zero = 0;
                            int j = 3 / zero;
                            break;
                        case "2":
                            int[] iArr = { 1, 2, 3 };
                            Console.WriteLine(iArr[3]);
                            break;
                        case "3":
                            string s = null;
                            Console.WriteLine(s.ToString());
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            break;
                    }
                }
                catch (DivideByZeroException e)
                {

                    Console.WriteLine("\n0으로 나누려 하는 오류 발생");

                } catch (NullReferenceException e) { 

                      Console.WriteLine("\n정의되지 않은 값(null)을 사용하는 오류 발생");

                }catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("\n배열의 범위를 벗어난 예외발생");
                }

                    Console.WriteLine("\n1.DivideByZeroException | 2.IndexOutOfRangeException | 3. NullReferenceException | ^C Exit");

                }
            }
        }
    }

