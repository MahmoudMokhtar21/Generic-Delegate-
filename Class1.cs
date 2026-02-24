using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public delegate bool Filter<in T>(T n);  //generic delegate <in T> 'mean parameter type => (T n)'
                                             //generic delegate <out T> 'delegate type' => public delegate T Filter<in T>(T n);
    // we will reblace Filter to Predicate(built-in delegate)


}
