using System;

namespace TriangleNameSpace
{
    public class Triangle
    {
        public bool IsTriangle(int a, int b, int c)
        {
            bool IsTr = false;
            if ((a < b + c) && (b < a + c) && (c < a + b))           
                IsTr = true;           
            return IsTr;
        }
    }
}
