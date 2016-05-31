using System;

public class ObjectBase
{
    public int x;
    public int y;
    public string name;
    
    public ObjectBase()
    {
        x = 0;
        y = 0;
        name = GetName();
    }

    public virtual void Set(int MAXX, int MAXY)
    {

    }

    public virtual int Get(int MAXX, int MAXY)
    {
        return 0;
    }

    public virtual string GetName()
    {
        return "none";
    }
}