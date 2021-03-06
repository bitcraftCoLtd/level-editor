﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor.Extensibility.ReadOnlyViewModels
{
    public interface IReadOnlyFlagViewModel : IReadOnlyRootedViewModel
    {
        int FlagNumber { get; }
        bool IsChecked { get; }
        string Semantic { get; }
    }
}
