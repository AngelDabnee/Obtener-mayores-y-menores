// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Algoritmo donde el usuario captura 20 números, súmalos y si el resultado es menor que 99,
// los multiplicas cada uno por 2 y los imprimes; si la suma entre ellos es mayor a 20000,
// los sumas todos entre ellos.
Console.WriteLine("En este programa capturaremos 20 números al azar, " +
    "de cualquier tipo. Si la suma de estos es <99 se multiplicará cada uno por " +
    "2 y se imprimirá el resultado, si son mayores que 20,000 " +
    "se imprimrá el resultado de la suma total");
//DE. 
double[] numeros = new double[20];
double aSuma = 0;//Acumulador de la suma. 
//Proceso. 
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Captura tu número " + (i+1));
    numeros[i] = double.Parse(Console.ReadLine());
}
for (int o = 0; o < numeros.Length; o++)//Con este for vamos a sumar los numeros capturados
{
    aSuma = aSuma + numeros[o];//La suma de los numero capturados. 
}
for (int i = 0; i < numeros.Length; i++)//Ciclo para poder multiplicar cada número por 2
{
    if (aSuma < 99)
    {
        numeros[i]=(numeros[i]*2);
        Console.WriteLine($"El resultado de cada numero que capturaste multiplicado por 2 es; {numeros[i]}");
    }
}
if (aSuma>20000)//Un if solo para sumar todos los números. 
{
    Console.WriteLine($"El resultado de la suma de los números capturados es {aSuma}");
}



