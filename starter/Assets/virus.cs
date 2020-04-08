using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<breaker>();

        StartCoroutine(gameObject.GetComponent < breaker>().SplitMesh(true));
    }

    
}
