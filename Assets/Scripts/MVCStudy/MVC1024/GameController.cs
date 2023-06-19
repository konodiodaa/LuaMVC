using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class GameController : Controller
{
    public TextAsset luaScript;
    LuaEnv luaenv = null;

    public View view;

    private void Awake()
    {
        luaenv = new LuaEnv();
        luaenv.DoString(luaScript.text);


        float row = luaenv.Global.Get<float>("row");
        float col = luaenv.Global.Get<float>("col");

        Bind(view, PlayerModel.Instance);
    }

    private void Update()
    {
        Action e = luaenv.Global.Get<Action>("UpdateGrid");
        e();
    }
}
