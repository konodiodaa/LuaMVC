using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void BroadcastAction(Model model);

public abstract class Model
{
    //这是注册部分
    private BroadcastAction actions;

    public void Register(BroadcastAction action)
    {
        actions += action;
        Broadcast();
    }
    public void Broadcast()
    {
        actions?.Invoke(this);
    }
}
//多继承差不多约等于类的合并，分开是因为可以加上泛型T，直接通过类名去调单例，同时保留基类Model的兼容性
public abstract class Model<T> : Model
{

    private static T model;
    public static T Instance
    {
        get
        {
            if (model == null) model = Activator.CreateInstance<T>();
            return model;
        }
    }
}