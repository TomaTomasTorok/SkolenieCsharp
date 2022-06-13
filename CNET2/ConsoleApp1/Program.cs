// See https://aka.ms/new-console-template for more information
using System.Linq;
using Data;
using Model;

Console.WriteLine("Hello, World!");
//FAResult fAResult  = new FAResult("file",SourceType.FILE);
//var x = await FreqAnalysis.FreqAnalysisForURL("https://raw.githubusercontent.com/kubicek-skoleni/NET6_CNET2/master/Books/alice.txt");
//Console.WriteLine( x);


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

var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var numbers1 = numbers.Select(n=> n.GetTypeCode());

Console.WriteLine(numbers1);


//foreach (int n in numbers1)
//{
//    Console.Writeline(n);
//}