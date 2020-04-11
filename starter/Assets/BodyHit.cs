using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHit : MonoBehaviour
{
    gameManager manager;
    private void Awake()
    {
        manager = GetComponent<gameManager>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        manager.end();
    }
}
