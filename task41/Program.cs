Console.WriteLine("Сколько элементов вы ходтите ввести");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[M];
Console.WriteLine("Вводите поочередно элементы");
for (int i=0; i<M;i++)
massiv[i] = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int j=0; j<M;j++)
if (massiv[j]>0)
count+=1;
Console.WriteLine("чисел больше нуля "+count);