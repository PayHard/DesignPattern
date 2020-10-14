using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IteratorInterface
    {
        public abstract Boolean hasNext();
        public abstract Object next();
    }
}
