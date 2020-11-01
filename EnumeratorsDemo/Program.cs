using System;
using System.Collections.Generic;

namespace EnumeratorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //как да имам форийч в C# за моя колекция - за това са енумераторите и yeld return. Това е много конкретно нещо, което може и да не ни потрябва, но е срещано и важно (не е фундаментална концепция като дженериците)
            //така направихме наш форич (много малко по различен от оригиналния)
            string[] array = Console.ReadLine().Split();
            StringEnumerator enumerator = new StringEnumerator(array);
            //IEnumerator enumerator = array.GetEnumerator(); с това е оригиналния!!!
            //Енумератора ни държи информация до къде сме стигнали в колекцията - само обхожда и знае до къде сме стигнали;
            //Йерархия - IEnumerable наследява IEnumerator, който има метод GetEnumerator(). Всичко което е IEnumerable има IEnumerator и съответно метода GetEnumerator(), който връща нов енумератор.
            //Ние винаги използваме IEnumerable<Т>, IEnumerable е за стари неща и някъде кода може да ни задължава да го слагаме.

            //yeld return - yeld е ключова думичка и е много интересна, позволява ни да върнем няколко пъти неща от един метод. 
            //В практиката навсякъде където искаме да имплементираме IEnumerable на наша колекция използваме yeld return. Идеята е да правим IEnumerable на колекция (може да е наша за да имаме форийч - за това са тези енумератори, затова е този yeld return )
            //yeld return спира изпълнението на метода до следващия път докато някой не е извикал MoveNext() или до следващата итерация на форийча. Когато форийча продължи на следващия item тогава отива на следващия yeld return.

            //yeld return връща по един елемент на всеки loop cycle

            //params е ключова дума с коятo можем да вземем почече на брой аргументи наведнъж. Само по един params е позволен.Позволен е при деклариране на метод или за конструктор. Трябва да е последния параметър.

            //на ilspy.Net Decompiler - ако си откраднеш от някъде код (някакво ехе) ти го декомпилира и ти дава реалния код

            //IComparable<T> означава мога да се сравнявам (можем да сравняваме 2 обекта които привидно няма по какво да сравним и ни позволява да сортираме) - ще имплементираме на книгата в LibraryIterator.
            //IComparable < T > ни дава CompareTo към другия тип
            //Taka можем напълно да контролираме и Ордер бай от това какво му кажем да ни връща CompareTo.
            //Сортировката на СортедСета също идва от CompareTo.
            //Идеята е че вече така можем на собствени класове да дадем как да се сортира по наша логика.
            //Първия обект е този на който викаме CompareTo, а втория е този който му подаваме в скобите!

            //IComparer - осигурява ни възможност да можем на собствени класове да дадем как да се сортира по наша логика и важното тук е че за разлика от IComparable не променя оригиналния клас, а прави нов клас.
            //Пример:
            //class Cat
            //{
            //public string Name { get; set }
            //}
            //class CatComparer : IComperer<Cat>
            //{
            //public int Compare(Cat x, Cat y)
            //}
            //това е много полезно
            //Важно е да разберем че можем да си правим свой клас комперар, който да си подаваме на сортирани колекции!
            //ICompareble се ползва по-често, но и двата начина стават! При работа с HashSet - ове може да се наложи да се ползват.
            //hackerRank - алгуритми и структури от данни - това е най-важното!!! ни препоръчяа ВикторДаков за хубави задачи!
            //В това видео последни 4 мин - добри насоки за  алгуритми и структури от данни !!!

            //foreach иска IEnumerator, a IEnumerator идва след имплементирането на IEnumerable : IEnumerable, Ctrl+. и  IEnumerator идва от задължителните методи на IEnumerable. yield return връща и трупа в  IEnumerator - а!

            //Comperators:
            //1. Always returns integer: -1 -Other object is bigger/ 0 - they are equals; +1 - Current object is bigger
            //2. Alwaya accepts T arg : IComparable

            // Other with this - assending order
            //This with other - decending order
            //n-тия елемент = n-1 index

            //Reference object are compared by Equals() method not by == sign - Obj1.Equals(Obj2)
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
