using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorCodeManual : ColorPair
    {
        internal int pairNo;

        /// <summary>
        /// function returns all the ColorCode pairs mapped with pairNo
        /// </summary>
        /// <param name="colorMapMajor">Array of Major color</param>
        /// <param name="colorMapMinor">Array of Minor color</param>
        /// <returns></returns>
        public static List<ColorCodeManual> GetColorCodeManual(Color[] colorMapMajor, Color[] colorMapMinor)
        {
            List<ColorCodeManual> lstpairscolorcode = new List<ColorCodeManual>();
            ColorCodeManual pairColorCode = null;
            for (int majorIndex = 0; majorIndex < colorMapMajor.Length; majorIndex++)
            {
                for (int minorIndex = 0; minorIndex < colorMapMinor.Length; minorIndex++)
                {
                    pairColorCode = new ColorCodeManual();
                    ColorPair colorPair = new ColorPair() { majorColor = colorMapMajor[majorIndex], minorColor = colorMapMinor[minorIndex] };
                    pairColorCode.majorColor = colorMapMajor[majorIndex];
                    pairColorCode.minorColor = colorMapMinor[minorIndex];
                    pairColorCode.pairNo = PairNumberFromColor.GetPairNumberFromColor(colorPair);
                    lstpairscolorcode.Add(pairColorCode);
                }
            }

            return lstpairscolorcode;
        }
    }
}
