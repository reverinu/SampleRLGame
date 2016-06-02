using System;

public class ObjectBase
{
    public int x;
    public int y;
    public string name;
    protected int MAXX;
    protected int MAXY;
    
    public ObjectBase()
    {
        x = 0;
        y = 0;
        name = GetName();
    }

    public void Set(int x, int y)
    {
        MAXX = x;
        MAXY = y;
    }
    
    public int Get()
    {
        return y * MAXX + x;
    }

    public virtual string GetName()
    {
        return "none";
    }
}