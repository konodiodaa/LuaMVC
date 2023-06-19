using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void BroadcastAction(Model model);

public abstract class Model
{
    //����ע�Ჿ��
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
//��̳в��Լ������ĺϲ����ֿ�����Ϊ���Լ��Ϸ���T��ֱ��ͨ������ȥ��������ͬʱ��������Model�ļ�����
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