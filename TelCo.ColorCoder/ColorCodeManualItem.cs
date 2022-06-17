using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorCodeManualItem : ColorPair
    {
        internal int pairNo;
        /// <summary>
        /// function returns all the ColorCode pairs mapped with pairNo
        /// </summary>
        /// <param name="colorMapMajor">Array of Major color</param>
        /// <param name="colorMapMinor">Array of Minor color</param>
        /// <returns></returns>
        public static List<ColorCodeManualItem> GetColorCodeManual(Color[] colorMapMajor, Color[] colorMapMinor)
        {
            List<ColorCodeManualItem> lstpairscolorcode = new List<ColorCodeManualItem>();
            ColorCodeManualItem pairColorCode = null;
            for (int majorIndex = 0; majorIndex < colorMapMajor.Length; majorIndex++)
            {
                for (int minorIndex = 0; minorIndex < colorMapMinor.Length; minorIndex++)
                {
                    pairColorCode = new ColorCodeManualItem();
                    ColorPair colorPair = new ColorPair() { majorColor = colorMapMajor[majorIndex], minorColor = colorMapMinor[minorIndex] };
                    pairColorCode.majorColor = colorMapMajor[majorIndex];
                    pairColorCode.minorColor = colorMapMinor[minorIndex];
                    pairColorCode.pairNo = PairNumberFromColor.GetPairNumberFromColor(colorPair);
                    lstpairscolorcode.Add(pairColorCode);
                }
            }
            return lstpairscolorcode;
        }

        public static void printReferenceManual(List<ColorCodeManualItem> lstpairscolorcode)
        {
            foreach (var pairscolorcode in lstpairscolorcode)
            {
                string formatedString = formatReferenceManualLineItem(pairscolorcode);
                formatedString.printMessageOnConsole();
            }
        }

        public static string formatReferenceManualLineItem(ColorCodeManualItem pairscolorcode)
        {
            return string.Format("[In]Pair Number: {0},[Out] Colors: {1}", pairscolorcode.pairNo, new ColorPair() { majorColor = pairscolorcode.majorColor, minorColor = pairscolorcode.minorColor });
        }
    }
}