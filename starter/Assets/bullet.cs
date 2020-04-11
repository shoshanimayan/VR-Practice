using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public gameManager Manager;
    public float time = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == transform.tag)
        {
            //    StartCoroutine(other.gameObject.GetComponent<breaker>().SplitMesh(true));

            Manager.increaseScore();
            Manager.hitSound();
            Destroy(other.gameObject);
            Destroy(transform.gameObject);
        }
       // Destroy(transform.gameObject);
    }
    private void Update()
    {
        if (time <= 0) { Destroy(gameObject); }
        time -= Time.deltaTime;
    }
}


