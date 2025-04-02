using GaderypolukiCypher;

Console.WriteLine("Podaj tekst do zakodowania: ");
string text = Console.ReadLine();
string output = Cypher.DictionaryGaderpoluki(text);
Console.WriteLine("Zaszyfrowany tekst: " + output);