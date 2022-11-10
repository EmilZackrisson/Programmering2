// See https://aka.ms/new-console-template for more information

int[] serieA = { 1, 7, 3, 4 };
int[] serieB = { 1, 32 };
int[] serieC = { 1, 12, 3 };
int[][] dubbelFält = { serieA, serieB, serieC };

int längdA = serieA.Length;
Console.WriteLine(längdA.ToString());
Console.WriteLine(serieA[1].ToString());

int söktVärde = dubbelFält[1][1];
Console.WriteLine(söktVärde.ToString());