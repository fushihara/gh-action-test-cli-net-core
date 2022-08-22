// See https://aka.ms/new-console-template for more information
Console.WriteLine("stdout start.");
int count = 0;
while (true) {
    char c1 = (char)('A' + (count%26));
    char c2 = (char)('a' + (count % 26));
    count += 1;
    Thread.Sleep(50);
    Console.Error.Write(c1.ToString());
    Thread.Sleep(50);
    Console.Out.Write(c2.ToString());
    if (c1 == 'Z') {
        Console.Error.Write("\n");
        Console.Out.Write("\n");
    }
}
