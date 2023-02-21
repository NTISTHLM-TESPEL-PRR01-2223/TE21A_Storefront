using System;

public class StoreTools
{

  public static int BossBattle(int hp, int level)
  {
    hp--;

    if (level > 6)
    {

    }

    return hp;
  }


  public static void ListWares(int[] prices, string[] wares)
  {
    for (int i = 0; i < prices.Length; i++)
    {
      int price = prices[i];
      string ware = wares[i];
      Console.WriteLine($"{i + 1}. {ware} [{price}]");
    }
  }

  public static int GetWareNumber()
  {
    Console.WriteLine("Vilken vill du köpa? Skriv siffra och tryck enter");

    string whichStr = Console.ReadLine();

    int which = 0;
    int.TryParse(whichStr, out which);

    which--;
    return which;
  }

  public static int Buy(int money, int[] prices)
  {
    int which = GetWareNumber();

    try
    {
      int price = prices[which];

      if (money >= price)
      {
        money -= price;
      }
      else
      {
        Console.WriteLine("Du är för fattig!");
      }
    }
    catch
    {
      Console.WriteLine("Är du dum eller!");
    }

    return money;
  }
}
