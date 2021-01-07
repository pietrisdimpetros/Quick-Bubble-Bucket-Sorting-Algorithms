using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBubbleBucket.Models
{
    public class TShirt
    {
        #region Public Properties
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        #endregion
        #region Constructors
        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
        #endregion
        #region ToString
        public void Stringify(TShirt shirt)
        {
            Console.WriteLine($"This T-shirt is of Size {shirt.Size}\t, Color {shirt.Color}\t and Fabric {shirt.Fabric}");
        }
        #endregion

    }
}
