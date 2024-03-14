// TASK 1


//int num = 7492;
//int enB = 0;
//int count = 0;
//while (num>0)
//{
//    count = num % 10;

//   if (enB < count)
//    {
//        enB = count;
//    }
//    num = num / 10;
//}   
//Console.WriteLine(  enB);


// TASK 2

//int num = 128;
//while (num % 2 == 0)
//{
//    num /= 2;
//}

//if (num == 1)
//{
//    Console.WriteLine("quvvetdir");
//}
//else
//{
//    Console.WriteLine("quvvet deyil");
//}
//    else
//{
//    Console.WriteLine("quvvet deyil");
//}


//TASK 3

//int [] num= {1,3,6,7,8,5 };
//int min = num[0];
//int max = num[1];
//int sum;
//for (int i = 0; i < num.Length; i++)
//{
//    if (min < num[i])
//    {
//        min = num[i];
//    }
//    else
//    {
//        if(max > num[i])
//        {
//            max = num[i];
//        }
//    }
//}
//sum = min + max;
//Console.WriteLine( sum);


//TASK 4


//int[] num = { 1, 5, 9, 18, 21 };
//int count = 0;
//for(int i= 0; i < num.Length; i++)
//{
//    if (num[i] % 2!=0 && num[i] %3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(  count);

//TASK5

//int[] arr = { 5, 9, 12, 11 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++) 
//{
//    for (int j = 2; j < arr[i]; j++) 
//    {
//        if (arr[i] % j == 0)
//        {
//            count++;
//        }
        
//    }
//}
//Console.WriteLine(count);