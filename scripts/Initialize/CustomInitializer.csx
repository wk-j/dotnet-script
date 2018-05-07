using System.Collections;
using System.Collections.Generic;

class Data<T> : IEnumerable<T>
{
    List<T> localData = new List<T>();

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public void Add(T t1)
    {
        localData.Add(t1);
    }

    public void Add(T t1, T t2, T t3)
    {
        localData.Add(t1);
        localData.Add(t2);
        localData.Add(t3);
    }
}

var data = new Data<int> {
    { 1 },
    { 1,1,1 }
};