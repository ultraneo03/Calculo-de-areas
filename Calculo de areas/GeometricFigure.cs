using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_areas
{
    /// <summary>
    /// public abstract class to represent geometric figure
    /// </summary>
    public abstract class GeometricFigure
    {
        /// <summary>
        /// method to calculate area  
        /// </summary>
        public abstract void CalculateArea();

        /// <summary>
        /// method to show information related to the figure
        /// </summary>
        public abstract void ShowInformation();

        /// <summary>
        /// method to show result of area calculation process
        /// </summary>
        public abstract void ShowResult();

    }
}
