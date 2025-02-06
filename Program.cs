using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace RtanRpg
{
    internal class Program
    {
        public class RtanRpg
        {asdasdasd


        }
        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");

            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            string inputn = Console.ReadLine();

            if (int.TryParse(inputn, out int num))
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine($"입력하신 숫자는 {num}입니다.");
                        InforMation();
                        break;

                    case 2:
                        Console.WriteLine($"입력하신 숫자는 {num}입니다.");
                        InvenTory();
                        break;


                    case 3:
                        Console.WriteLine($"입력하신 숫자는 {num}입니다.");
                        Store();
                        break;

                    default:
                        Console.WriteLine(" 1 ~ 3 중에 선택하세요");
                        break;
                }
            }
            else if (num >= 1 && num <= 3)
            {
                Console.WriteLine("1 ~ 3 중에 선택하세요");
            }

            else
            {
                Console.WriteLine("잘못된 입력입니다. 1 ~ 3 중에 선택하세요");
            }


        }
        static void InforMation()
        {
            string[] infor = { "Lv. 01", "Chad 김규태", "공격력 : 10", "방어력 : 5", "체력 : 100", "Gold : 1500 G" };

            foreach (string item in infor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("0. 나가기");
        }
        static void InvenTory()
        {
            Console.WriteLine("[아이템 목록]");
            string[] inven = { "1. 장착 관리", "0. 나가기" };
            foreach (string iv in inven)
            {
                Console.WriteLine(iv);
            }
            string inputn_1 = Console.ReadLine();
            if (int.TryParse(inputn_1, out int num2))
            {
                switch (num2)
                {
                    case 1:
                        Console.WriteLine($"입력하신 숫자는 {num2}입니다.");
                        E_setting();
                        break;

                    case 2:
                        Console.WriteLine($"입력하신 숫자는 {num2}입니다.");
                        break;
                }
            }
        }
        static void E_setting()
        {
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할수있습니다");
            string[] e_inven = { "1 [E]무쇠갑옷    |방어력 +5|", "2 [E]스파르타 창    |공격력 +7|", "3 낡은 검    |공격력 +2]" , "", "0. 나가기"};
                foreach (string E_list in e_inven)
            {
                Console.WriteLine(E_list);
            }
        }
        static void Store()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("800 G");
            string[] store = { "1 수련자 값옷    |방어력 +5|", "2 무쇠 갑옷    |방어력 +9|", "3 스파르타의 갑옷    |방어력 +15]", "4 낡은 검    |공격력 +2|", "5 청동 도끼    |공격력 +5|", "6 스파르타의 창    |공격력 +7|" };
                foreach (string S_list in store)
                {
                Console.WriteLine(S_list);
                }

            Console.Write("\n원하는 아이템 번호를 입력하세요: ");
            int s_input = int.Parse(Console.ReadLine());

            
                
        }    
    }
}

