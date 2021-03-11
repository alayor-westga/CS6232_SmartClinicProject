using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.View
{
    public interface SelectionListener<T>
    {
        void OnSelect(T selectedValue);

        void OnDoubleClickSelect(T selectedValue);

        void OnSelectionCleared();
    }
}
