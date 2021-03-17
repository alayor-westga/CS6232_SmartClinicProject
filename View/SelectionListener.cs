using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.View
{
    /// <summary>
    /// It represents an object that listens for selected values.
    /// </summary>
    public interface SelectionListener<T>
    {
        /// <summary>
        /// Called when a selection has been made.
        /// </summary>
        void OnSelect(T selectedValue);

        /// <summary>
        /// Called when a selection has been made by double click.
        /// </summary>
        void OnDoubleClickSelect(T selectedValue);

        /// <summary>
        /// Called when the selecion is cleared.
        /// </summary>
        void OnSelectionCleared();
    }
}
