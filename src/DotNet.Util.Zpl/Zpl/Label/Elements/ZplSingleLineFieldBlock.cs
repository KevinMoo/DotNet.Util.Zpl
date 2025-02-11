﻿namespace DotNet.Util.Zpl.Label.Elements
{
    /// <summary>
    /// Similar to ZplTextField with big line spacing, so only the first line is visible
    /// </summary>
    public class ZplSingleLineFieldBlock : ZplFieldBlock
    {
        /// <summary>
        /// ZplSingleLineFieldBlock
        /// </summary>
        /// <param name="text"></param>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="width"></param>
        /// <param name="font"></param>
        /// <param name="textJustification"></param>
        /// <param name="newLineConversion"></param>
        /// <param name="useHexadecimalIndicator"></param>
        /// <param name="reversePrint"></param>
        public ZplSingleLineFieldBlock(
            string text,
            int positionX,
            int positionY,
            int width,
            ZplFont font,
            TextJustification textJustification = TextJustification.Left,
            NewLineConversionMethod newLineConversion = NewLineConversionMethod.ToSpace,
            bool useHexadecimalIndicator = true,
            bool reversePrint = false)
            : base(text, positionX, positionY, width, font, 9999, 9999, textJustification, 0, newLineConversion, useHexadecimalIndicator, reversePrint)
        {
        }
    }
}
