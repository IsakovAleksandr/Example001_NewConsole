int a = 4;
int b = 5;
int c = 8;
int d = 1;
int e = 9;

int max = a;

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("макимальное значение = ");
Console.Write(max);