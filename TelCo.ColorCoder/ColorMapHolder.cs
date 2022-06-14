﻿using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorMapHolder
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor { get; }
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor { get; }

        /// <summary>        
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorMapHolder()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
