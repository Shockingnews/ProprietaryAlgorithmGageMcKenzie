using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

public class Test3 : MonoBehaviour
{
    //public int dimensions;
    //public test[] tileObjects;
    //public List<test2> gridComponents;
    //public test2 cellObj;

    //public test backUpTile;

    //private int iteration;
    
    //private void Awake()
    //{
    //    gridComponents = new List<test2>();
    //    InitializeGrid();
    //}

    //void InitializeGrid()
    //{
    //    for(int i = 0; i <  dimensions; i++)
    //    {
    //        for (int j = 0; j < dimensions; j++)
    //        {
    //            test2 newCell = Instantiate(cellObj, new Vector3(j,0,i), Quaternion.identity);
    //            newCell.CreateCell(false, tileObjects);
    //            gridComponents.Add(newCell);
    //        }
    //    }
    //    StartCoroutine(CheckEntropy());
    //}

    //IEnumerator CheckEntropy()
    //{
    //    List<test2>  tempGrid = new List<test2>(gridComponents);
    //    tempGrid.RemoveAll(c  => c.collapsed);
    //    tempGrid.Sort((a,b) => a.Options.Length - b.Options.Length);
    //    tempGrid.RemoveAll(a => a.Options.Length != tempGrid[0].Options.Length);
    //    yield return new WaitForSeconds(0.001f);

    //    CellapseCell(tempGrid);
    //}

    //void CellapseCell(List<test2> tempGrid)
    //{
    //    int randIndex = UnityEngine.Random.Range(0, tempGrid.Count);

    //    test2 cellToCollapse = tempGrid[randIndex];

    //    cellToCollapse.collapsed = true;

        
        
    //    try
    //    {
            
    //        test selectedTile = cellToCollapse.Options[UnityEngine.Random.Range(0, cellToCollapse.Options.Length)];
    //        cellToCollapse.Options = new test[] { selectedTile };
    //    }
    //    catch
    //    {
    //        test selectedTile = backUpTile;
    //        cellToCollapse.Options = new test[] { selectedTile };
    //    }
        

    //    test foundTile = cellToCollapse.Options[0];
    //    Instantiate(foundTile, cellToCollapse.transform.position,foundTile.transform.rotation);

    //    UpdateGeneration();

    //}

    //void UpdateGeneration()
    //{
    //    List<test2> newGenerationCell = new List<test2>(gridComponents);

    //    for(int i = 0; i < dimensions; i++)// i = y
    //    {
    //        for(int j = 0; j < dimensions; j++) //j=x
    //        {
    //            var index = j + i * dimensions;

    //            if (gridComponents[index].collapsed)
    //            {
    //                newGenerationCell[index] = gridComponents[index];
    //            }
    //            else
    //            {
    //                List<test> options = new List<test>();
    //                foreach(test t in tileObjects)
    //                {
    //                    options.Add(t);
    //                }

    //                if(i > 0)
    //                {
    //                    test2 up = gridComponents[j + (i - 1) * dimensions];
    //                    List<test> validOptions = new List<test>();

    //                    foreach (test possibleOptions in up.Options)
    //                    {
    //                        var validOption = Array.FindIndex(tileObjects, obj => obj == possibleOptions);
    //                        var valid = tileObjects[validOption].downNeighbours;

    //                         validOptions.Concat(valid).ToList();
    //                    }

    //                    CheckValidity(options, validOptions);
    //                }
    //                if(j < dimensions - 1)
    //                {
    //                    test2 left = gridComponents[j + 1 + i * dimensions];
    //                    List<test> validOptions = new List<test>();

    //                    foreach(test possibleOptions in left.Options)
    //                    {
    //                        var validOption = Array.FindIndex(tileObjects, obj => obj == possibleOptions);
    //                        var valid = tileObjects[validOption].rightNeighbours;

    //                        validOptions.Concat(valid).ToList();
    //                    }
    //                    CheckValidity(options, validOptions);
    //                }
    //                if (i < dimensions - 1)
    //                {
                        
    //                    test2 down = gridComponents[j + (i + 1) * dimensions];
    //                    List<test> validOptions = new List<test>();

    //                    foreach (test possibleOptions in down.Options)
    //                    {
    //                        var validOption = Array.FindIndex(tileObjects, obj => obj == possibleOptions);
    //                        var valid = tileObjects[validOption].upNeighbours;

    //                        validOptions.Concat(valid).ToList();
    //                    }

    //                    CheckValidity(options, validOptions);
    //                }
    //                if (j >0)
    //                {
    //                    test2 right = gridComponents[j - 1 + i * dimensions];
    //                    List<test> validOptions = new List<test>();

    //                    foreach (test possibleOptions in right.Options)
    //                    {
    //                        var validOption = Array.FindIndex(tileObjects, obj => obj == possibleOptions);
    //                        var valid = tileObjects[validOption].leftNeighbours;

    //                        validOptions.Concat(valid).ToList();
    //                    }
    //                    CheckValidity(options, validOptions);
    //                }
    //                test[] newTileList = new test[options.Count];
    //                for(int k = 0; k < options.Count; k++)
    //                {
    //                    newTileList[k] = options[k];
    //                }
    //                newGenerationCell[index].RecreateCell(newTileList);
    //            }
    //        }
    //    }
    //    gridComponents = newGenerationCell;

    //    if(iteration < dimensions * dimensions)
    //    {
    //        StartCoroutine(CheckEntropy());
    //    }

        
    //}
    //void CheckValidity(List<test> optionList,List<test> validOption)
    //{
    //    for (int i = optionList.Count- 1; i >= 0; i--)
    //    {
    //        var element = optionList[i];
    //        if (!validOption.Contains(element))
    //        {
    //            optionList.RemoveAt(i);
    //        }
    //    }
    //}
}
