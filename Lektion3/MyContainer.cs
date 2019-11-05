public class MyContainer
{
    private object[] _theObjects;
    private int _n;

    public MyContainer()
    {
        _theObjects = new object[2];
        _n = 0;
    }

    public void Add(object o)
    {
        // If necessary, grow the array
        if (_n == _theObjects.Length)
        {
            object[] oldArray = _theObjects;
            _theObjects = new object[2 * oldArray.Length];
            Array.Copy(oldArray, _theObjects, _n);
        }

        _theObjects[_n] = o;
        _n++;
    }

    public object GetAt(int i)
    {
        return _theObjects[i];
    }

    public int Count
    {
        get { return _n; }
    }
}