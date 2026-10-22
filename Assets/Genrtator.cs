using UnityEngine;
using System.Collections.Generic;

public class Genrtator : MonoBehaviour
{
    public GameObject cubePrefab;

    private List<GameObject> _cubes = new List<GameObject>();

    int randomNumCubes;

    public Vector2 positionRange = new Vector2(10f, 10f);

    float minCubeYSize = 1.0f;

    public float cubePositionZ;

    public float cubePositionX;

    float maxCubeYSize = 10f;
    public  bool isStarted = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNumCubes = Random.Range(20,51);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            GenerateCubes(randomNumCubes);
        }
        CheckPos();



    }

    public void RegenerateCubes()
    {
        randomNumCubes = Random.Range(20, 51);
        int numOfCubes = randomNumCubes;
        for(int i  = 0; i < _cubes.Count; i++)
        {
            Destroy(_cubes[i]);
            _cubes.Remove(_cubes[i]);
        }
        for (int i = 0; i < numOfCubes; i++)
        {
            
            GameObject cube = GameObject.Instantiate(cubePrefab);
            Debug.Log(i);

            cubePositionX = Random.Range(-positionRange.x, positionRange.x + 1);
            cubePositionZ = Random.Range(-positionRange.y, positionRange.y + 1);

            cube.transform.position = new Vector3(cubePositionX, 0f, cubePositionZ);

            cube.transform.localScale = new Vector3(1f, Random.Range(minCubeYSize, maxCubeYSize + 1), 1f);

            //Rigidbody rb = cube.AddComponent<Rigidbody>();
            //rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;


            _cubes.Add(cube);
            CheckPos();
           
        }
    }

    void GenerateCubes(int numOfCubes)
    {
        
        
        for (int i = 0; i < numOfCubes; i++)
        {
            GameObject cube = GameObject.Instantiate(cubePrefab);
            Debug.Log(i);

            cubePositionX = Random.Range(-positionRange.x, positionRange.x + 1);
            cubePositionZ = Random.Range(-positionRange.y, positionRange.y + 1);

            cube.transform.position = new Vector3(cubePositionX, 0f, cubePositionZ);

            cube.transform.localScale = new Vector3(1f, Random.Range(minCubeYSize, maxCubeYSize + 1), 1f);
            
            //Rigidbody rb = cube.AddComponent<Rigidbody>();
            //rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
            

            _cubes.Add(cube);
            CheckPos( );
            if (i+1 >= numOfCubes)
            {
               isStarted = false;
            }
        }

        

    }

    void CheckPos()
    {
        for (int i = 0; i < _cubes.Count; i++)
        {
            for (int j = 0; j < _cubes.Count; j++)
            {
                if (i != j)
                {
                    float distance = Vector3.Distance(_cubes[i].transform.position, _cubes[j].transform.position);
                    if (distance <= 1.5f || distance <= -1.5f)
                    {
                        cubePositionX = Random.Range(-positionRange.x, positionRange.x + 1);
                        cubePositionZ = Random.Range(-positionRange.y, positionRange.y + 1);

                        _cubes[j].transform.position = new Vector3(cubePositionX, 0f, cubePositionZ);

                        _cubes[j].transform.localScale = new Vector3(1f, Random.Range(minCubeYSize, maxCubeYSize + 1), 1f);
                    }
                    
                }
            }
        }
    }
}
