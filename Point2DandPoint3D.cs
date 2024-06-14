class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D() { }
    public Point2D(float x, float y) { this.x = x; this.y = y; }
    public void SetX(float x) { this.x = x; }
    public float GetX() { return x; }
    public void SetY(float y) { this.y = y; }
    public float GetY() { return y; }

    public void SetXY(float x, float y) { }
    public float[] GetXY()
    {
        return new float[] { x, y };
    }
    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}

class Point3D : Point2D
{
    private float z = 0.0f;
    public Point3D() { }
    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }
    public void SetZ(float z) { this.z = z; }
    public float GetZ() { return z; }
    public void SetXYZ(float x, float y, float z) { }
    public float[] GetXYZ()
    {
        return new float[] { GetX(), GetY(), z };
    }
    public override string ToString()
    {
        return "(" + GetX() + ", " + GetY() + ", " + z + ")";
    }
}