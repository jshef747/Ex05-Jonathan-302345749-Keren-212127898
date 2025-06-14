using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolPgia;
public class ColorMapping
{
    public static readonly Dictionary<Color, char> sr_KColorMapping = new Dictionary<Color, char> 
                                                                          {
                                                                              { Color.Chartreuse, 'A' },
                                                                              { Color.RoyalBlue, 'B' },
                                                                              { Color.Crimson, 'C' },
                                                                              { Color.DeepPink, 'D' },
                                                                              { Color.Plum, 'E' },
                                                                              { Color.LightSkyBlue, 'F' },
                                                                              { Color.LightSeaGreen, 'G' },
                                                                              { Color.Purple, 'H' }
                                                                          };
}
