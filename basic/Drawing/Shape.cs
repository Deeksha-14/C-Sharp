namespace drawing;

public abstract class Shape
{

    private int width;
    private string color;

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }
    public Shape()
    {
        this.width = 2;
        this.color = "black";
    }

    public Shape(int w, string c)
    {
        this.width = w;
        this.color = c;
    }


    //method name capital
    public abstract void Draw();



}