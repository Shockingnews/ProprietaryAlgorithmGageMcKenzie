using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Cell : MonoBehaviour
{
    public bool collapsed;
    public Tile[] tileOptions;

    public void CreateCell(bool collapsedState, Tile[] tiles)
    {
        collapsed = collapsedState;
        tileOptions = tiles;
    }

    public void RecreateCell(Tile[] tiles)
    {
        tileOptions = tiles;
    }
}
