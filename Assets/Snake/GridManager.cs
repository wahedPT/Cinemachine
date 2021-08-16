using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{//1:46:00 time
    [SerializeField]
    GridTile gridTilePrefab;

    [SerializeField]
    Transform playArea;
    [SerializeField]
    int gridSize = 10;
    //setgrid size //get and set the value
    public int Gridsize
    {
        get { return gridSize; }
    }
    //start point
    Vector3 startPoint;
    public Vector3 StartPoint { get { return startPoint; } }

    int width, height;
    Transform[,] grid;
      
    public void InitializeGrid()
    {
        width = Mathf.RoundToInt(playArea.localScale.x * gridSize);
        height = Mathf.RoundToInt(playArea.localScale.y * gridSize);
        grid = new Transform[width, height];
        startPoint = playArea.GetComponentInChildren<Renderer>().bounds.min;
        Debug.Log(startPoint);
        createGridTile();

    }

    private static void createGridTile()
    {
        if (gridTilePrefab == null)
            return;
        for (int i=0; i < height; i++)
            {
            for (int y=0; y < width; y++)
            {
                Vector3 worldPos = GetWorldPos(i,y);
                GridTile gridTile = Instantiate(gridTilePrefab, worldPos, Quaternion.identity);
                gridTile.name = string.Format("Tile({ 0},{ 1})", i, y);
                grid[i, y] = gridTile.transform;
            }
        }
    }

    private static Vector3 GetWorldPos(int a,int b)

    {
        float sp = a;
        float ep = b;
        return new Vector3(startPoint.x + (sp / gridsize), startPoint.y + (ep / gridsize),startPoint.z);

    }

    private void Start()
    {
        InitializeGrid();
    }
}
