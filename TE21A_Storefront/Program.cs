// x Lista sakerna man kan köpa
// Skriver in vilken man vill köpa
// Kollar om man har råd
// Drar av pengar

int money = 10;



int[] prices = { 50, 25, 1, -20, 10 };
string[] wares = { "Äpple", "Kossa", "Bil" , "Take a loan", "Balloon"};


while (true)
{
  StoreTools.ListWares(prices, wares);

  money = StoreTools.Buy(money, prices);

  Console.WriteLine($"Du har {money} pengar kvar");
}

Console.ReadLine();


int hp = 100;
int level = 0;
