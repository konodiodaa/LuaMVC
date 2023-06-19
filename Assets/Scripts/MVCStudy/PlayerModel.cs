using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
//[LuaCallCSharp]
public class PlayerModel : Model<PlayerModel>
{
    private int[] grids = {0};

    public int[]
        Grids { get { return this.grids; } }

    //public int GetGridCount() { return grids.Length; }

    public void AddLev(int[] grids)
    {
        //this.grids = new List<int>(grids);
        this.grids = grids;
        Broadcast();
    }
}