using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    internal class ColorCodeManualTestMethod
    {
        public static void ColorCodeManual()
        {
            Console.WriteLine("Color code Manual");
            ColorPair colorPair;
            List<ColorCodeManual> lstofpairColorCode = ColorCoder.ColorCodeManual.GetColorCodeManual(ColorMapHolder.colorMapMajor, ColorMapHolder.colorMapMinor);
            int increment = 1;
            int majorIndex = 0;
            int minorIndex = 0;
            foreach (var pairColorCode in lstofpairColorCode)
            {
                colorPair = new ColorPair();
                colorPair.majorColor = pairColorCode.majorColor;
                colorPair.minorColor = pairColorCode.minorColor;
                Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", colorPair, pairColorCode.pairNo);
                Debug.Assert(colorPair.majorColor == ColorMapHolder.colorMapMajor[majorIndex]);
                Debug.Assert(colorPair.minorColor == ColorMapHolder.colorMapMinor[minorIndex]);
                Debug.Assert(pairColorCode.pairNo == increment);
                if (minorIndex >= ColorMapHolder.colorMapMinor.Length - 1)
                {
                    minorIndex = 0;
                    majorIndex++;
                    increment++;
                    continue;
                }
                increment++;
                minorIndex++;
            }
        }
    }
}
