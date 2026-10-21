using UnityEngine;
using System.Collections.Generic;

public class Genrtator : MonoBehaviour
{
    private List<GameObject> _cubes;

    int randomNumCubes;

    public Vector2 positionRange = new Vector2(10f, 10f);

    float minCubeYSize = 1.0f;

    float maxCubeYSize = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNumCubes = Random.Range(5, 21);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateCubes()
    {
        for (int i = 0; i < randomNumCubes; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _cubes.Add(cube);
        }
        
    }
}
