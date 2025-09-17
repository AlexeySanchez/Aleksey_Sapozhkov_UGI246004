using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Мороз и солнце; день чудесный!\nЕще ты дремлешь, друг прелестный —\nПора, красавица, проснись:\nОткрой сомкнуты негой взоры\r\nНавстречу северной Авроры,\nЗвездою севера явись!\n");
            Console.WriteLine("Вечор, ты помнишь, вьюга злилась,\nНа мутном небе мгла носилась;\nЛуна, как бледное пятно,\nСквозь тучи мрачные желтела,\nИ ты печальная сидела —\nА нынче… погляди в окно:\n");
            Console.WriteLine("Под голубыми небесами\nВеликолепными коврами,\nБлестя на солнце, снег лежит;\nПрозрачный лес один чернеет,\nИ ель сквозь иней зеленеет,\nИ речка подо льдом блестит.\n");
            Console.WriteLine("Вся комната янтарным блеском\nОзарена. Веселым треском\nТрещит затопленная печь.\nПриятно думать у лежанки.\nНо знаешь: не велеть ли в санки\nКобылку бурую запречь?\n");
            Console.WriteLine("Скользя по утреннему снегу,\nДруг милый, предадимся бегу\nНетерпеливого коня\nИ навестим поля пустые,\nЛеса, недавно столь густые,\nИ берег, милый для меня.\n");
            Console.WriteLine("1829 г.");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
