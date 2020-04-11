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
    public float timer = 0;
    public gameManager manager;
   
    // Start is called before the first frame update
    void Awake()
    {
        bullet.GetComponent<bullet>().Manager = manager;
        held = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (held )
        {
            triggerDown = false;

            InputDevice hand = InputDevices.GetDeviceAtXRNode(handType);
            hand.TryGetFeatureValue(CommonUsages.triggerButton , out triggerDown);
            if ( triggerDown )
            {
             //   manager.gunSound();
                Instantiate(bullet, bullethole.transform.position, bullethole.transform.rotation).GetComponent<Rigidbody>().AddForce(bullethole.transform.right * 500f);
            }
            
           
            
        }
        else {
            if (bullethole.transform.parent.parent==transform)
            {
                held = true;
            }
        }
    }
}
