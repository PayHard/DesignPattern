using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface AggregateInterface
    {
        public abstract IteratorInterface iterator();
    }
}
