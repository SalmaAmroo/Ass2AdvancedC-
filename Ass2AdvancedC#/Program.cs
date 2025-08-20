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

        #region Q6
        //public static bool IsPalindrome()
        //{
        //    Console.WriteLine("Enter the size of the array:");
        //    int N = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the elements of the array:");
        //    string[] Inputs = Console.ReadLine().Split(' ');

        //    int[] Array = new int[N];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        Array[i] = int.Parse(Inputs[i]);
        //    }

        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        for (int j = Array.Length - 1-i; j >= 0; j--)
        //        {
        //            if (j > i)
        //            {
        //                if (Array[i] != Array[j])
        //                {
        //                return false;
        //                }
        //                break;
        //            }

        //        }

        //    }
        //    return true;
        //}
        #endregion

        #region Q7
        //public static void ReverseQueue (Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }

        //}
        #endregion

        #region Q8
        //public static bool IsBalanced (string Expression)
        //{
        //    Stack<Char> stack = new Stack<char>();
        //    foreach (char c in Expression)
        //    {
        //        if (c == '[' || c == '(' || c == '{')
        //            stack.Push(c);
        //        else if (c == ']' || c == ')' || c == '}')
        //        {
        //            if (stack.Count == 0)
        //                return false;
        //            char top = stack.Pop();
        //            if ((c == ']' && top != '[') || (c == ')' && top != '(') || (c == '}' && top != '{'))
        //                return false;

        //        }
        //    }
        //    return stack.Count == 0;

        //}
        #endregion

        #region Q9
        //public static int[] RemoveDuplicatedElements (int[] Array)
        //{
        //    List<int> Elements = new List<int>();

        //    for (int i=0;i<Array.Length;i++)
        //    { 
        //        bool Found = false;
        //        for (int j=0;j<Elements.Count;j++)
        //        {
        //            if (Array[i] == Elements[j])
        //                Found = true;
        //        }
        //        if (!Found)
        //            Elements.Add(Array[i]);
        //    }
        //    return Elements.ToArray ();

        //}
        #endregion

        #region Q10
        //public static ArrayList RemoveOddNumber(ArrayList  arrayList)
        //{
        //    ArrayList evenNumbers = new ArrayList();
        //    for (int i = 0; i < arrayList.Count; i++)
        //    { 
        //        int number = (int)arrayList[i];
        //        if (number %2 ==0)
        //        {
        //            evenNumbers.Add(number);
        //        }


        //    }
        //    return evenNumbers;

        //}
        #endregion

        #region Q12
        //public static void Search()
        //{ 
        //  Stack <int> stack = new Stack<int>();
        //  Console.WriteLine("Enter the size of stack :");
        //  int size = int.Parse(Console.ReadLine());
        //  Console.WriteLine("Enter the elements of stack :");
        //    for (int i = 0; i < size; i++)
        //    {
        //        stack.Push(int.Parse(Console.ReadLine()));
        //    }

        //   Console.WriteLine("Enter the Target to search :");
        //   int target = int.Parse(Console.ReadLine());

        //   bool found = false;
        //   int Count = 0;
        //    foreach (int num in stack)
        //    {   
        //        Count++;
        //        if (target == num)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {Count}");
        //            found = true;
                    
        //        }
                 
        //    }
        //    if (!found)
        //    {
        //        Console.WriteLine("Target was not found in the stack.");
        //    }




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

            #region Q5
            //Console.WriteLine("Enter the size of the array & number of queries with split ' ':");
            //string[] GetSize = Console.ReadLine()?.Split(' ');
            //int N = int.Parse(GetSize[0]);
            //int Q = int.Parse(GetSize[1]);

            //int[] Array = new int[N];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the X of the query:");

            //for (int i = 0; i < Q; i++)
            //{ 
            //    int X = int.Parse(Console.ReadLine());
            //    int Count = 0;

            //    for (int j = 0; j < Array.Length; j++)
            //    {
            //        if (Array[j] < X)
            //        {
            //            Count++;
            //        }
            //    }
            //    Console.WriteLine($"Count : {Count}");


            //}



            #endregion

            #region CallQ6
            //if (IsPalindrome())
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");

            //}
            #endregion

            #region CallQ7
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine("Original Queue:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //ReverseQueue(queue);
            //Console.WriteLine("Reversed Queue:");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region CallQ8
            //string expression = "{[()]}";
            //if (IsBalanced(expression))
            //{
            //    Console.WriteLine($"{expression} is Balanced.");
            //}
            //else
            //{
            //    Console.WriteLine($"{expression} isNot Balanced.");
            //}
            #endregion

            #region CallQ9
            //int[] Array = { 1, 2, 3, 4, 5, 1, 2 ,3,6};
            //int[] Array2 = RemoveDuplicatedElements(Array);

            //for (int i = 0; i < Array2.Length; i++)
            //{
            //    Console.WriteLine(Array2[i] + " ");  
            //}
            #endregion

            #region CallQ10
            //ArrayList arrayList = new ArrayList() { 1,2,3,4,5,6,7};
            //ArrayList arr2= RemoveOddNumber(arrayList);
            //Console.WriteLine("Even Numbers:");
            //foreach (int item in arr2)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Q11
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Karim");
            //queue.Enqueue(3.14);

            //Console.WriteLine("Queue contents:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region CallQ12
          //  Search();
            #endregion
        }
    }
}
