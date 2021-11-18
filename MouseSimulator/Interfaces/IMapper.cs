using System;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator.Interfaces
{
  internal interface IMapper<T, U>
    where T : Enum
    where U : Enum
  {
    T Map(U item);
    U Map(T item);
  }
}
