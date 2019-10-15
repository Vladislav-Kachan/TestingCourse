using System;

namespace TriangleNameSpace
{
    public static class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0));
        }
    }
}
