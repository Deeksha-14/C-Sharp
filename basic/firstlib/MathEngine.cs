namespace maths;


public static class MathEngine
{

    public static int Addition(int o1, int o2)
    {
        int temp = o1 + o2;
        return temp;
    }

    public static int Subraction(int o1, int o2)
    {
        int result = o1 - o2;
        return result;
    }

    public static void swap(ref Object o1, ref Object o2)
    {
        object temp = o1;
        o1 = o2;
        o2 = temp;

    }

    public static void calculate(int radius, out double area, out double circumference)
    {
        const double PI = 3.14;
        area = PI * radius * radius;
        circumference = 2 * PI * radius;

    }

}