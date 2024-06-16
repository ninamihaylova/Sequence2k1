 class Sequence2k1 {
    public static void Main (string[]args)
    {

        int n = int.Parse(Console.ReadLine());
        int number=1;
        while (number<=n) {
            Console.WriteLine(number);
            number=number*2+1;

        }

    }
}