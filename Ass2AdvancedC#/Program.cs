using System.Collections;

namespace Ass2AdvancedC_
{
    #region Q3
    //class FixedSizeList<T>
    //{
    //    public int Capacity { get; set; }
    //    public T[] Items { get; set; }

    //    public int Count { get; set; }
    //    public FixedSizeList(int Capacity)
    //    {
    //        if (Capacity <= 0)
    //            Console.WriteLine("Capacity must be greater than zero.");
    //        this.Capacity = Capacity;

    //        Items = new T[Capacity];
    //        Count = 0;
    //    }
    //    public void Add(T Items)
    //    {
    //        if (Count >= Capacity)
    //        {
    //            throw new InvalidOperationException("List is Full");
    //        }

    //        this.Items[Count] = Items;
    //        Count++;
    //    }
    //    public T GetElement(int index)
    //    {
    //        if (index < 0 || index >= Count)
    //        {
    //            throw new ArgumentOutOfRangeException("Index is out of range.");
    //        }
    //        return Items[index];

    //    }

    //}
    #endregion
    internal class Program
    {
        #region Q1 
        //public static void ReverseArrayList(ArrayList ArrayList)
        //{
        //    int FirstIndex = 0;
        //    int LastIndex = ArrayList.Count - 1;

        //    while (FirstIndex < LastIndex)
        //    { 
        //        object? Temp = ArrayList[FirstIndex];
        //        ArrayList[FirstIndex] = ArrayList[LastIndex];
        //        ArrayList[LastIndex] = Temp;

        //        FirstIndex++;
        //        LastIndex--;

        //    }

        //}
        #endregion

        #region Q4
        //public static int NonRepeatedCharacter (string word)
        //{
        //    Dictionary<char, int> Characters = new Dictionary<char, int>();

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (Characters.ContainsKey(word[i]))
        //        {
        //            Characters[word[i]]++;
        //        }
        //        else
        //        {
        //            Characters[word[i]] = 1;
        //        }
        //    }
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (Characters[word[i]] == 1)
        //            return i;

        //    }
        //    return -1; 
        //}

        #endregion

        static void Main(string[] args)
        {
            #region CallQ1
            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine("Original ArrayList:");
            //foreach (int item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //ReverseArrayList(arrayList);
            //Console.WriteLine("Original ArrayList:");
            //foreach (int item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Q2

            //List<int> List = new List<int> {1,2,3,4,5,6,7,8};
            //List<int> EvenNumbers= List.FindAll(N => N % 2 == 0);
            //Console.WriteLine("Even Numbers:");
            //foreach (int item in EvenNumbers)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region CallQ3

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(4);
            //fixedSizeList.Add(6);
            //fixedSizeList.Add(8);
            //fixedSizeList.Add(10);
            //try 
            //{
            //    fixedSizeList.Add(12); 
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"The Element is : { fixedSizeList.GetElement(0)}");

            //try
            //{
            //    Console.WriteLine($"The Element is : {fixedSizeList.GetElement(6)}");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region CallQ4

           //string word = "aKarim";
           //int index = NonRepeatedCharacter(word);
           // if (index != -1)
           // {
           //     Console.Write($"The First Character NonRepeated is : {word[index]} And its index : {index}");
           // }
           // else
           // {
           //     Console.WriteLine("There is no non-repeated character in the word.");
           // }


            #endregion


        }
    }
}
