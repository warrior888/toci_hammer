using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Toci.Hammer.HashMap
{
    public abstract class GrMegaDictionaryBase<TParentKey, TChildKey, TValue> : IMegaDictionary<TParentKey, TChildKey, TValue>
    {
        protected Dictionary<TParentKey, TChildKey> ParentMap = new Dictionary<TParentKey, TChildKey>();
        protected Dictionary<TChildKey, TValue> ChildrenMap = new Dictionary<TChildKey, TValue>();

        public virtual bool Add(TParentKey parent, TChildKey child, TValue value)
        {
            ParentMap.Add(parent, child);
            ChildrenMap.Add(child, value);

            return true;
        }

        public bool Delete(TParentKey key)
        {
            // ??
            ParentMap.Remove(key);  // hanna

            return true;
        }

        public bool Delete(TChildKey key)
        {
            throw new System.NotImplementedException(); // hanna
        }
    }
}