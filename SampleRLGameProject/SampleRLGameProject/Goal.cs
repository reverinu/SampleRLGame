using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Goal : ObjectBase
{
    public Goal()
    {
        name = GetName();
    }

    public override string GetName()
    {
        return "goal";
    }
}
