namespace drawing;

public sealed class Line : Shape
{
    private Point startPoint;
    private Point endPoint;


    public Point StartPoint
    {
        get { return this.startPoint; }
        set { this.startPoint = value; }
    }


    public Point EndPoint
    {
        get { return this.endPoint; }
        set { this.endPoint = value; }
    }

    public Line() : base()
    {
        this.startPoint = new Point();
        this.endPoint = new Point();

    }

    public Line(Point pt1, Point pt2, int w, string c) : base(w, c)
    {
        this.startPoint = pt1;
        this.endPoint = pt2;
    }

    public override void Draw()
    {
        string data = string.Format("({0},{1}),({2},{3}), width ={4}, color ={5}", startPoint.x, startPoint.y, endPoint.x, endPoint.y, Width, Color);
    }


}