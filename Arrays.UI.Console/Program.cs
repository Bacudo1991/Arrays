using Arrays.Logic;


try
{
    Console.WriteLine("\n::::::::::::::: WORKING WITH ARRAYS ::::::::::::::\n");
    int option;
    MyArray myArray = new(10);
    myArray.Fill();
    do
    {
        option = Menu();
        switch (option)
        {
            case 0:
                Console.WriteLine(":::::::::: GAME OVER ::::::::::");
                break;
            case 1:
                Console.WriteLine();
                Console.Write("Ingrese número de elementos: ");
                var nString = Console.ReadLine();
                int n = 10;
                int.TryParse(nString, out n);
                myArray = new(n);
                myArray.Fill();
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine();
                Console.WriteLine("Arreglo: ");
                myArray.Sort();
                Console.WriteLine(myArray);
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine("Números pares: ");
                myArray.Sort();
                Console.WriteLine(myArray.GetEvens());
                Console.WriteLine();
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine("Números primos: ");
                myArray.Sort();
                Console.WriteLine(myArray.GetPrimes());
                Console.WriteLine();
                break;
            case 5:
                Console.WriteLine();
                Console.WriteLine("Números que no se repiten: ");
                myArray.Sort();
                Console.WriteLine(myArray.GetNonRepeated());
                Console.WriteLine();
                break;
            case 6:
                Console.WriteLine();
                Console.WriteLine("Números mas repetidos: ");
                myArray.Sort();
                Console.WriteLine(myArray.GetMostRepeated());
                Console.WriteLine();
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Fuck you. Opción no valida");
                Console.WriteLine();
                break;                
        }
    } while (option != 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int Menu()
{
    Console.WriteLine("1. Definir tamaño de arreglo");
    Console.WriteLine("2. Mostrar arreglo");
    Console.WriteLine("3. Mostrar números pares");
    Console.WriteLine("4. Mostrar números primos");
    Console.WriteLine("5. Mostrar números que no se repiten");
    Console.WriteLine("6. Mostrar que más se repiten");
    Console.WriteLine("0. Salir");
    bool isValid = false;
    int option = 0;
    do
    {
        Console.Write("Digite su opción: ");
        var optionString = Console.ReadLine();

        if (!int.TryParse(optionString, out option))
        {
            Console.WriteLine("Opción no valida, solo ingrese números");
            isValid = false;
        }
        else
        {
            isValid = true;
        }
    } while (!isValid);
    return option;

}

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