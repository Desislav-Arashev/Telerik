using System;

namespace Print
{
    public class Print
    {
        public const int MaxCount = 6;

        public class RenderBulean
        {
            public void Render(bool boolValue)
            {
                string renderedBoolValue = boolValue.ToString();
                Console.WriteLine(renderedBoolValue);
            }
        }
    }
}
