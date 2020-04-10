using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class shoot : MonoBehaviour
{
    private bool held;
    private bool triggerDown;
    public XRNode handType;
    public GameObject bullethole;
    public GameObject bullet;
    
    // Start is called before the first frame update
    void Awake()
    {
        held = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (held)
        {
            triggerDown = false;
            InputDevice hand = InputDevices.GetDeviceAtXRNode(handType);
            hand.TryGetFeatureValue(CommonUsages.triggerButton, out triggerDown);
            if (triggerDown) {
                Instantiate(bullet,bullethole.transform.position,bullethole.transform.rotation).GetComponent<Rigidbody>().AddForce(bullethole.transform.right*100f);
            }
        }
        else {
            if (transform.childCount >0)
            {
                held = true;
            }
        }
    }
}
