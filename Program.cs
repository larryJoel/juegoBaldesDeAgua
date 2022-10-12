// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Balde balde01 = new Balde(15,10,"verde");
Balde balde02 = new Balde(10,0,"rojo");
Console.WriteLine(balde01.ToString());
balde01.agregar(5);
balde01.baldeVacio();
balde01.quitar(4);
Console.WriteLine($"*****************************");
balde01.vuelcaEn(balde01,balde02,12);
