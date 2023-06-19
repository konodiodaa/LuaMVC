using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    //����������ǲ���Ҫ�û��Լ�ȥʵ�֣�ÿ�ζ�һ�����ṩ�����ˣ��̳б������һ��
    protected void Bind(View view, Model model)
    {
        model.Register(view.UpdateView);
    }
}


