using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolPgia;
public class ColorMapping
{
    public static readonly Dictionary<char, Color> sr_KColorMapping = new Dictionary<char, Color>
    {
        { 'A', Color.Chartreuse },
        { 'B', Color.RoyalBlue },
        { 'C', Color.Crimson },
        { 'D', Color.DeepPink },
        { 'E', Color.Plum },
        { 'F', Color.LightSkyBlue },
        { 'G', Color.LightSeaGreen },
        { 'H', Color.Purple }
    };
}
