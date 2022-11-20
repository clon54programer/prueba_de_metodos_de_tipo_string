Console.WriteLine("deme una oracion: ");
string harr = Console.ReadLine();
Console.WriteLine(harr.ToUpper());
Console.WriteLine(harr.Clone());
Console.WriteLine(harr.Clone().ToString());

Console.WriteLine(harr.CompareTo(harr));
Console.WriteLine(harr.Insert(14, " juan es prohacker"));
Console.WriteLine(harr.LastIndexOf("j"));//nos da la ubicavion de la letra declarada 
Console.WriteLine(harr.Remove(6));
Console.WriteLine(harr.Replace("j", "w"));
Console.WriteLine(harr.Substring(0,10));//nos muestra pedazos cortos de lo que ingrese
Console.WriteLine(harr.Trim());
