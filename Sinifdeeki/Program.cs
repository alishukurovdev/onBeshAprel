
namespace Sinifdeeki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test test = new Test();
            // test.Arr[0] = 11;
            // test.Arr[1] = 14;
            // test.Arr[2] = 77;
            // test.Arr[3] = 7;
            //// test.Arr[11] = 41;
            // for (int i = 0; i < test.Arr.Length; i++) {
            //     Console.WriteLine(test[i]);
            // }
            Test t = new Test();
            foreach (var item in typeof(Test).GetProperties(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)) {
                //Console.WriteLine(item.Name);
               item.SetValue(t, 20);
                Console.WriteLine(item.GetValue(t));
            }
        }
        class Test
        {
            private int A { get; set; } = 5;
            public int[] Arr { get; }
          //  public int Length => Arr.Length;
            //public int this[int i]
            //{
            //    get {
            //        return Arr[i];                }
            //    set
            //    {
            //        if (value < 0)
            //            throw new ArgumentException();
            //        if(i>=Arr.Length)
            //            throw new IndexOutOfRangeException();

            //    }
            //} 
        }
    }
}
