using Arrays.Logic;

try
{
    var myMatrix = new MyMatrix();
    myMatrix.Fill();
    var mainDiagonal = myMatrix.GetMainDiagonal();
    var secondaryDiagonal = myMatrix.GetSecondaryDiagonal();

    Console.WriteLine("\n:::::::::: MATRIX ::::::::::\n");
    Console.WriteLine(myMatrix);
    Console.WriteLine("\n::::::: MAIN DIAGONAL ::::::\n");
    Console.WriteLine(mainDiagonal);
    Console.WriteLine("\n::::: SECONDARY DIAGONAL :::\n");
    Console.WriteLine(secondaryDiagonal);
    Console.WriteLine("\n::::: UPPER TRIANGULAR :::::\n");
    Console.WriteLine(myMatrix.GetUpperTriangular());
    Console.WriteLine("\n::::: LOWER TRIANGULAR :::::\n");
    Console.WriteLine(myMatrix.GetLowerTriangular());

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
