using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerView : View
{
    public override void UpdateView(Model model)
    {
        PlayerModel playerModel = (PlayerModel)model;

        //txt1.text = "HP:" + playerModel.HP.ToString();
        //txt2.text = "Ex:" + playerModel.Ex.ToString();
    }
}
