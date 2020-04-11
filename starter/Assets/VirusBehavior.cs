using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior : MonoBehaviour
{
    public Vector3 movement= new Vector3(0, 0, -6);
    public GameObject destination;

    float dTime = 0;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 1 If not using physics, this will update the movements of the veggies.
        if (rb.isKinematic)
        {
            // 2 Move from the origin to the position for the note in the first second.
            /*dTime += Time.deltaTime;

            if (dTime < 1.0f)
            {
                // 3 Lerp along the X/Y axis to the correct lane.
                Vector3 position = transform.position;
                float z = position.z;
                position.z = destination.transform.position.z;

                position = Vector3.Lerp(position, destination.transform.position, dTime);
                position.z = z;
                transform.position = position;
            }
            */
            // 4 Move along Z
            transform.Translate(movement * Time.deltaTime*.5f);
        }
    }
}
