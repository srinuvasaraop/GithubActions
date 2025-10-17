namespace Doubts;

delegate int helo(int i);
public class Lamda1
{

    static void Main(string[] args)
    {
        Func<int,int> sqaure= x => x * x;
        sqaure(10);
    }
   
}

 