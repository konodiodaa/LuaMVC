using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    //这个方法我们不需要用户自己去实现，每次都一样，提供就行了，继承本类调用一次
    protected void Bind(View view, Model model)
    {
        model.Register(view.UpdateView);
    }
}


