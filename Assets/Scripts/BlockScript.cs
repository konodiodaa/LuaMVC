using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockScript : MonoBehaviour
{
    public int num;
    public SpriteRenderer sr;
    public Text numText;
    public int ID;

    [SerializeField]
    private Color colors;

    private void Awake()
    {
       // GetComponent<Button>().onClick.AddListener(hello);
    }

    private void OnDestroy()
    {
        
    }

    private void hello()
    {
        
    }
}
