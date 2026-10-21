using UnityEngine;
using System.Collections.Generic;

public class Genrtator : MonoBehaviour
{
    private List<GameObject> _cubes;

    float randomNumCubes;

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

            float cubePositionX = Random.Range(-positionRange.x, positionRange.x + 1);
            float cubePositionZ = Random.Range(-positionRange.y, positionRange.y + 1);

            cube.transform.position.x = cubePositionX;
            cube.transform.position.z = cubePositionZ;

            cube.transform.localScale = Vector3.one * Random.Range(minCubeYSize, maxCubeYSize+1);
        }
        
    }
}
