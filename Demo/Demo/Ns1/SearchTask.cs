using ReactiveUI;
using ReactiveUI.SourceGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ns1;

public partial class SearchTask : ReactiveObject
{
    [Reactive] private int _id;
}
