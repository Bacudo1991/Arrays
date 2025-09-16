using System.ComponentModel.DataAnnotations;

namespace Arrays.Logic;

public class MyArray
{
    private int _top;           //Logic size
    private int[] _array;

    public MyArray(int n)
    {
        N = n;
        _array = new int[n];
        _top = 0;
    }

    public bool IsFull => _top == N;

    public bool IsEmpty => _top == 0;

    public int N { get; }           //PROPIEDAD DE LECTURA - SOLO GET  -- Phisical size 

    public void Add(int number)
    {
        if (IsFull)
        {
            throw new Exception("The array is full.");
        }

        _array[_top] = number;
        _top++;
    }

    public void Insert(int number, int position) 
    {
        if (IsFull)
        {
            throw new Exception("The array is full.");
        }
        if (position < 0 || position > _top)
        {
            position = 0;
        }
        if (position > _top)
        {
            position = _top;
        }

        for (int i = _top; i > position; i--)
        {
            _array[i] = _array[i - 1];
        }
        _array[position] = number;
        _top++;
    }

    public void Remove(int position)
    {
        if (IsEmpty)
        {
            throw new Exception("The array is empty.");
        }
        if (position < 0)
        {
            position = 0;
        }
        if (position > _top)
        {
            position = _top;
        }

        for (int i = position; i < _top - 1; i++)
        {
            _array[i] = _array[i + 1];
        }
        _top--;
    }

    public void Fill()
    {
        Fill(1, 100);
    }

    public void Fill(int minimum, int maximum)
    {
        Random random = new();
        for (int i = 0; i < N; i++)
        {
            _array[i] = random.Next(minimum, maximum);
            _top++;
        }
        _top = N;
    }

    public MyArray GetPrimes()
    {
        int primesCount = 0;
        for (int i = 0; i < _top; i++)
        {
            if (IsPrime(_array[i]))
            {
                primesCount++;
            }
        }
        var primesArray = new MyArray(primesCount);
        for (int i = 0; i < _top; i++)
        {
            if (IsPrime(_array[i]))
            {
                primesArray.Add(_array[i]);
            }
        }
        return primesArray;
    }

    public MyArray GetEvens()
    {
        var evensCount = 0;
        for (int i = 0; i < _top; i++)
        {
            if (IsEven(_array[i]))
            {
                evensCount++;
            }
        }

        var evensArray = new MyArray(evensCount);
        for (int i = 0; i < _top; i++)
        {
            if (IsEven(_array[i]))
            {
                evensArray.Add(_array[i]);
            }
        }
        return evensArray;

    }

    public MyArray GetNonRepeated()
    {
        int nonRepeatedCount = 0;
        for (int i = 0; i < _top; i++)
        {
            bool isRepeated = false;
            for (int j = 0; j < _top; j++)
            {
                if (i != j && _array[i] == _array[j])
                {
                    isRepeated = true;
                    break;
                }
            }
            if (!isRepeated)
            {
                nonRepeatedCount++;
            }
        }
        var nonRepeated = new MyArray(nonRepeatedCount);
        for (int i = 0; i < _top; i++)
        {
            bool isRepeated = false;
            for (int j = 0; j < _top; j++)
            {
                if (i != j && _array[i] == _array[j])
                {
                    isRepeated = true;
                    break;
                }
            }
            if (!isRepeated)
            {
                nonRepeated.Add(_array[i]);
            }
        }
        return nonRepeated;
    }

    public MyArray GetMostRepeated()
    {
        int[,] matrixCount = new int[_top, 2];
        int topMatrix = 0;

        for (int i = 0; i < _top; i++)
        {
            int j = 0;
            for (; j < topMatrix; j++)
            {

            }
            if (j == _top)
            {
                matrixCount[topMatrix, 0] = _array[i];
                matrixCount[topMatrix, 1] = 1;
                topMatrix++;
            }

        }





        for (int i = 0; i < _top; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                }
            }
    }

    public override string ToString()
    {
        if (IsEmpty)
        {
            return "Empty Array";
        }

        string output = string.Empty;
        var count = 0;
        for (int i = 0; i < _top; i++)
        {
            output += $"{_array[i]}\t";
            count++;
            if (count > 9)
            {
                count = 0;
                output += "\n";
            }
        }
        return output;
    }

    public void Sort()
    {
        Sort(descending: false);
    }

    public void Sort(bool descending)
    {
        for (int i = 0; i < _top - 1; i++)
        {
            for (int j = i + 1; j < _top; j++)
            {
                if (descending)
                {
                    if (_array[i] < _array[j])
                    {
                        Change(ref _array[i], ref _array[j]);
                    }
                }
                else
                {
                    if (_array[i] > _array[j])
                    {
                        Change(ref _array[i], ref _array[j]);
                    }
                }
            }
        }
    }

    private bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    
    private bool IsPrime(int n)
    {
        if (n == 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }    

    private void Change(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }
}
