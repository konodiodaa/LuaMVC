using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : Controller
{
    public View view;
    public Button btn;


    private void Start()
    {
        Bind(view, PlayerModel.Instance);
        // btn.onClick.AddListener(PlayerModel.Instance.AddLev);
    }
}