using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using UnityEngine.UI;
using System;



public class GridManager : View
{
    [SerializeField]
    private int row;
    [SerializeField]
    private int col;

    [SerializeField]
    private Text[] gridText;
    [SerializeField]
    private Image[] gridColors;

    [SerializeField]
    private Color[] colors;

    public GameObject boardGO;
    public GameObject nodeGO;


    private Dictionary<int,Color> colorMap = new Dictionary<int,Color>();

    private void Awake()
    {
        gridText = new Text[row * col];
        gridColors = new Image[row * col];
        InitGrid(row, col);
        InitColorMap();
    }

    private void InitGrid(float row,float col)
    {
        GameObject board = GameObject.Instantiate(boardGO, this.transform);
        board.transform.localScale = new Vector3(row + 0.1f, col + 0.1f, 1.0f);

        for(int i = 0; i < row ; i++)
        {
            for(int j= 0; j < col; j++)
            {
                GameObject node = GameObject.Instantiate(nodeGO,
                this.transform);
                node.transform.localPosition = new Vector3(i * 100 - 150, j * 100 - 150, 0.0f);
                gridText[(int)(i * col + j)] = node.GetComponentInChildren<Text>();
                gridColors[(int)(i * col + j)] = node.GetComponent<Image>();
            }
        }
    }

    private void InitColorMap()
    {
        int num = 0;
        for(int i = 0;i< colors.Length;i++)
        {
            colorMap.Add(num, colors[i]);
            if(num == 0)
            {
                num = 2;
            }
            else
                num *= 2;
        }
    }

    public override void UpdateView(Model model)
    { 
        PlayerModel playerModel = (PlayerModel)model;

        int[] grids = playerModel.Grids;
        int index = 0;

        for (int i = 0;i< gridText.Length; i++)
        {
            if(index > grids.Length - 1)
            {
                gridText[i].text = "";
                gridColors[i].color = new Color(colorMap[0].r, colorMap[0].g, colorMap[0].b);
            }
            else
            {
                if (grids[index] == 0)
                    gridText[i].text = "";
                else
                    gridText[i].text = grids[index].ToString();

                gridColors[i].color = new Color(colorMap[grids[index]].r, 
                    colorMap[grids[index]].g, 
                    colorMap[grids[index]].b);
                index++;
            }
        }
    }
}
