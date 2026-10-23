using UnityEngine;

public class HightCHange : MonoBehaviour
{
    void Awake()
    {
        transform.localScale += new Vector3(0.1f, Random.Range(0, 5 + 1), 0.1f);
    }
    
}
