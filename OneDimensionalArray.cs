using System;
using HomeWork_Makarov_Ivan_number_3;
namespace HomeWork_Makarov_Ivan_number_3._1
{
    public sealed class OneDimensionalArray<T> : BaseArray<T>
    where T : IComparable<T>
    {

        private T[] array;
        private int size;
        public const int defaultsize = 7;


        public OneDimensionalArray()
        {
            array = new T[defaultsize];
            size = 0;
        }
        public OneDimensionalArray(int n)
        {
            array = new T[n];
            size = 0;
        }



        public override void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
        }
        public void AddElement(T new_element_in_array)
        {
            if (size >= array.Length)
            {
                Array.Resize(ref array, array.Length * 2 + 1);
            }
            array[size] = new_element_in_array;
            size++;
        }


        public void FlipArray<T>(T[] array)
        {
            T element;
            for (int i = 0; i < array.Length; i++)
            {
                element = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = element;
            }
        }


        public int CountOfElementsThatSatisfyCondition(Predicate<T> condition)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (condition(array[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public T[] SelectionSortArray()
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    T el = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = el;
                }
            }
            return array;
        }



        public void ElementInArrayOrNot()
        {
            bool in_array = false;
            Console.WriteLine("Вводите элемент для проверки: ");
            T el = Provider.ConvertFromString(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(el) == 0)
                {
                    in_array = true;
                }
            }
            if (in_array)
            {
                Console.WriteLine("Элемент находится в массиве");
            }
            else
            {
                Console.WriteLine("Элемент не находится в массиве");
            }


        }
        public T[] GetArrayElementsThatSatisfyCondition()
        {
            Console.WriteLine("Введите номер элемента: ");
            int numb_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер ещё одного элемента: ");
            int numb_2 = int.Parse(Console.ReadLine());
            T[] new_array = new T[array.Length];
            for (int j = numb_1; j < numb_2; j++)
            {
                new_array[j] = array[j];
            }
            return new_array;
        }


        public T MinValue()
        {
            T min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min.CompareTo(array[i]) > 0)
                {
                    min = array[i];
                }
            }
            return min;

        }
        public T MaxValue()
        {
            T max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                {
                    max = array[i];
                }
            }
            return max;

        }

        public void DoWithEveryElement(Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }
        public bool IfOnlyOneElementSatisfyCondition(Func<T, bool> conditions)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (conditions(array[i]))
                {
                    return true;

                }

            }
            return false;

        }
        















    }

    
}