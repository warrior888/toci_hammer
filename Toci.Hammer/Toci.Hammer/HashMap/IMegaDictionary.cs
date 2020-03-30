namespace Toci.Hammer.HashMap
{                                       //tata      syn
    public interface IMegaDictionary<TParentKey, TChildKey, TValue>
    {
        bool Add(TParentKey parent, TChildKey child, TValue value);

        bool Delete(TParentKey key);

        bool Delete(TChildKey key);
    }
}