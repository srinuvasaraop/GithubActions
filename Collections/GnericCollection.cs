namespace Collections;

public class GnericCollection
{
   static void Main(string[] args)
   {
      List<int> list = new List<int>();
      list.Add(5);
      list.Add(6);
      list.Add(7);
      list.Add(8);
      list.Add(9);
      list.Add(10);
      
      for (int i = 0; i < list.Count; i++)
      {
          Console.WriteLine(list[i]);
      }

      foreach (var VARIABLE in list)
      {
          Console.WriteLine(VARIABLE);
      }
   }
}