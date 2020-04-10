using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 destination;

    float dTime = 0;

    Rigidbody rb;

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
            dTime += Time.deltaTime;

            if (dTime < 1.0f)
            {
                // 3 Lerp along the X/Y axis to the correct lane.
                Vector3 position = transform.position;
                float z = position.z;
                position.z = destination.z;

                position = Vector3.Lerp(position, destination, dTime);
                position.z = z;
                transform.position = position;
            }

            // 4 Move along Z
            transform.Translate(movement * Time.deltaTime);
        }
    }
}
