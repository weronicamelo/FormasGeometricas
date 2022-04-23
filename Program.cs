Quadrado q1 = new Quadrado(10.0);
Quadrado q2 = new Quadrado(2.0);

Console.WriteLine("Quadrado 1");
Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

Console.WriteLine("---------------------");
Console.WriteLine("Quadrado 2");
Console.WriteLine(q2.Lado);
Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);

q1.Lado = 8.0;

Retangulo r1 = new Retangulo(8.0, 5.0);
Retangulo r2 = new Retangulo(3.0, 6.0);

Console.WriteLine("---------------------");
Console.WriteLine("Retangulo 1");
Console.WriteLine(r1.Base);
Console.WriteLine(r1.Altura);
Console.WriteLine(r1.Area);
Console.WriteLine(r1.Perimetro);

Console.WriteLine("---------------------");
Console.WriteLine("Retangulo 2");
Console.WriteLine(r2.Base);
Console.WriteLine(r2.Altura);
Console.WriteLine(r2.Area);
Console.WriteLine(r2.Perimetro);
