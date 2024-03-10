using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

public class ListPerson<T>
{
    const int length = 0;
    T[] array; 
    public ListPerson()
    {
        array = new T[length];
    }
    public void Add(T value)
    {
        var temp = new T[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }
        temp[array.Length] = value;
        array = temp;
    }
    public int Length { get => array.Length; }

    public T this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            var temp = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            array = temp;
            array[index] = value;
        }
    }

    public T this[string name]
    {
        get         
        {
            return array[0];
        }
        set { /* set the specified index to value here */ }
    }
}
