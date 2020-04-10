using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == transform.tag)
        {
            StartCoroutine(other.gameObject.GetComponent<breaker>().SplitMesh(true));
        }
       // Destroy(transform.gameObject);
    }
}
