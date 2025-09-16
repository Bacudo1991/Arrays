using Arrays.Logic;



MyArray array = new(1000);
array.Fill(1, 200);
array.Sort();
Console.WriteLine(array);
Console.WriteLine("=================================================");
var nonRepeated = array.GetNonRepeated();
nonRepeated.Sort();
Console.WriteLine(nonRepeated);

//:::::::::::::::::: GetPrimes method ::::::::::::::::::
//MyArray array = new(50000);
//array.Fill(1, 999999);
//Console.WriteLine(array);
//Console.WriteLine("=====================================");
//var date1 = DateTime.Now;
//var primes = array.GetPrimes();
//var date2 = DateTime.Now;
//var time = date2 - date1;
//primes.Sort();
//Console.WriteLine(primes);
//Console.WriteLine($"Time elapsed: {time.Minutes} minutes, {time.Seconds} seconds, {time.Milliseconds} milliseconds, {time.Nanoseconds} nanoseconds.");


//:::::::::::::::::: Array Sort Evens :::::::::::::::::::
//try
//{
//    MyArray array = new(500);
//    array.Fill();
//    Console.WriteLine(array);
//    Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
//    var evens = array.GetEvens();
//    evens.Sort();
//    Console.WriteLine(evens);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//::::::::::::: Insert and remove methods ::::::::::::::::
//try
//{
//    MyArray array = new(5);
//    array.Add(10);
//    array.Add(20);
//    array.Add(30);
//    array.Insert(8, 0);              //number, position
//    Console.WriteLine(array);
//    array.Remove(0);              //number, position
//    Console.WriteLine("___________________");
//    Console.WriteLine(array);
//}
//catch (Exception ex)
//{
//   Console.WriteLine(ex.Message);
//}

//::::::::::: Add method::::::::::::::
//try
//{
//       MyArray array = new(5);
//        array.Add(10);
//      array.Add(20);
//        array.Add(30);
//        array.Add(40);
//        array.Add(50);
//        array.Add(60);
//        Console.WriteLine(array);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
    

//:::::::::::: Sort array :::::::::::::::
//MyArray array = new(5);
//array.Fill(1, 100);
//Console.WriteLine("Unsorted array");
//Console.WriteLine(array);

//array.Sort(descending: false);
//Console.WriteLine("Ascending Sorted array");
//Console.WriteLine(array); 

//array.Sort(descending: true);  
//Console.WriteLine("Descending Sorted array");
//Console.WriteLine(array); 