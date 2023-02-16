// x Lista sakerna man kan köpa
// Skriver in vilken man vill köpa
// Kollar om man har råd
// Drar av pengar

int money = 10;

int[] prices = { 50, 25, 1, -20, 10 };
string[] wares = { "Äpple", "Kossa", "Bil" , "Take a loan", "Balloon"};

while (true)
{
  for (int i = 0; i < prices.Length; i++)
  {
    int price = prices[i];
    string ware = wares[i];
    Console.WriteLine($"{i+1}. {ware} [{price}]");
  }

  Console.WriteLine("Vilken vill du köpa? Skriv siffra och tryck enter");

  string whichStr = Console.ReadLine();

  int which = 0;
  int.TryParse(whichStr, out which);

  which--;

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

  Console.WriteLine($"Du har {money} pengar kvar");
}

Console.ReadLine();
