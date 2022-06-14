using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorCodeTestMethods
    {
        public static void TestColorFromPairNumber()
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorFromPairNumber.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorFromPairNumber.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorFromPairNumber.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);
            
        }

        public static void TestPairNumberFromColor()
        {
            int pairNumber;
            ColorPair colorPair = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = PairNumberFromColor.GetPairNumberFromColor(colorPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", colorPair, pairNumber);
            Debug.Assert(pairNumber == 18);

            colorPair = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = PairNumberFromColor.GetPairNumberFromColor(colorPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", colorPair, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
