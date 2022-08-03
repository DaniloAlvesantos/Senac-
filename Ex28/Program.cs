long vn1 = 1234567;
byte vn2 = 132;
double vn3 = 123.45;

string vc1, vc2,vc3;

Console.WriteLine(vn1.ToString());
Console.WriteLine(vn2.ToString());
Console.WriteLine(vn3.ToString());

vc1 = vn1.ToString(); // "1234567"
vc2 = vn2.ToString(); // "123"
vc3 = vn3.ToString(); // "123.45"

Console.WriteLine();
Console.WriteLine(vc1.Length); // 7
Console.WriteLine(vc2.Length); // 3
Console.WriteLine(vc3.Length); // 6