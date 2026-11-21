#region Q1
double[] prices = { 25.5, 40.0, 33.75 };
Console.WriteLine(prices[1]);
#endregion
#region Q2
int[,] shelfCopies =
{
    { 3 , 5 },
    { 1 ,4 }
};
Console.WriteLine(shelfCopies[0,1]);
#endregion

#region Q3
void PrintWelcomeMessage(){
    Console.WriteLine("Welcome to the Library!");
}
PrintWelcomeMessage();

#endregion
#region Q4
void PrintBookTitle(string title)  {
    Console.WriteLine("Book title: " + title);

}
PrintBookTitle("Clean Code");

#endregion
#region Q5
void AddBonusPages(int pages)
{

    pages += 50;

}
int pages = 400;
AddBonusPages(pages);
Console.WriteLine( pages);
// i expect that pages increased by 50 but it doesnt because its pass by value
#endregion
#region Q6
void ApplyDiscount(double[] prices){
    prices[0] -= 5;

}
double[] prices01 = { 25.5, 40.0 };

ApplyDiscount(prices01);
Console.WriteLine(prices01[0]);
// i expect that prices01[0] decreased by 5  because its pass by ref

#endregion
#region Q7
void AddBonusPages01(ref int pages)
{

    pages += 50;

}
int pages01 = 400;
AddBonusPages01(ref pages01);
Console.WriteLine(pages01);
// i expect that pages increased by 50  because its pass by reff
#endregion
#region Q8
  void ReplaceArray(ref double[] prices){
    double[] newarray = { 10.0, 12.5, 15.0 };
    prices = newarray;
    
}
double[] arrayPrices = { 1.2, 8478, 20.8, 77.1, 88.3 };
ReplaceArray(ref arrayPrices);
Console.WriteLine("array length"+ arrayPrices.Length);

#endregion
#region Q9
bool TryGetPrice(string title, out double price )
{
    if (title == "Clean Code")
    {
        price =  25.5;
        return true;

    } 
    else
    {
        price = 0;
        return false;
    }
}
double result;
if (TryGetPrice("Clean Code",out result))
Console.WriteLine( result);
#endregion
#region Q10
void PrintBookInfo(string title, int pagesss = 300){
    Console.WriteLine("Book title: " + title +" pages :" +pages);

}
PrintBookInfo("mahmoud");
PrintBookInfo("mahmoud", 200);

#endregion
#region Q11
PrintBookInfo(pagesss : 250, title : "khaled");
#endregion
#region Q12
void PrintAllTitles(params string[] titles)
{
    for (int i = 0; i < titles.Length; i++)
    {
        Console.WriteLine(titles[i]);
    }
}
PrintAllTitles("mahmoud", "mohamed", "mostafa");
#endregion