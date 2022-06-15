// See https://aka.ms/new-console-template for more information
using System.Linq;
using Data;
using Model;

//Console.WriteLine("Hello, World!");
//FAResult fAResult = new FAResult("file", SourceType.FILE);
//var x = await FreqAnalysis.FreqAnalysisForURL("https://raw.githubusercontent.com/kubicek-skoleni/NET6_CNET2/master/Books/alice.txt");
//Console.WriteLine(x);


//var booksdir = @"C:\Users\StudentEN\source\repos\TomasT";
//var files = Directory.EnumerateFiles(booksdir, "*.txt");
//// var result = await FreqAnalysis.FreqAnalysisForURL("https://raw.githubusercontent.com/kubicek-skoleni/NET6_CNET2/master/Books/alice.txt");
//foreach (var file in files)
//{
//    var result = FreqAnalysis.FreqAnalysisForFile(file);
//    var ordered = result.OrderByDescending(x => x.Value).Take(10);
//    foreach (var item in ordered)
//    {
//        Console.WriteLine($"{item.Key}: {item.Value}");
//    }

//    Console.WriteLine(ordered);
//}

//var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var numbers1 = numbers.Select(n=> n.GetTypeCode());

//Console.WriteLine(numbers1);


//foreach (int n in numbers1)
//{
//    Console.Writeline(n);
//}
Client client1 = new Client() { Name= "petr"};
Client client2 = new Client() { Name= "pes"};
Client client3 = new Client() { Name= "jozo"};
ClientVIP client10 = new ClientVIP() {Name= "Anna", Status= "A"};
ClientVIP client11 = new ClientVIP() {Name= "HANA", Status= "B"};
ClientVIP client12 = new ClientVIP() {Name= "xxx", Status= "C"};
List<IGreetable> clients = new List<IGreetable>();
clients.Add(client1);
clients.Add(client2);
clients.Add(client3);
clients.Add(client10);


GreetClient(clients);


 static void GreetClient(List <IGreetable> clients) {

    foreach (IGreetable o in clients)
    {
        Console.WriteLine(o.SayHello());
    }

}
var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\Desktop\xml\dataset.xml");
Console.WriteLine(dataset.Count());

var order = dataset.OrderBy(x => x.Age());
var first=order.First();
var last=order.Last();
var a =dataset.Where(n => n.Contracts.Count() > 0 ).Count();
var c = dataset.Where(n => n.HomeAddress.City == "Brno");


Console.WriteLine($"{first} {first.Age()}");
Console.WriteLine($"{last} {last.Age()}");
//Console.WriteLine(last.Age());
//foreach (var o in c) {  

//Console.WriteLine(o);
//}