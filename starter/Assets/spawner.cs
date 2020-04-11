using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject v1;
    public GameObject v2;
    private GameObject[] spots;
    private GameObject[] viruses;
    private float counter;
    private float cutoff;
    public float BPM = 172f;

    // Start is called before the first frame update
    void Awake()
    {
        spots = new GameObject[] { s1, s2, s3, s4, s5, s6 };
        viruses = new GameObject[] { v1, v2 };

        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
        s5.SetActive(false);
        s6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        float beatInterval = 60.0f / BPM;

        // 1. Veggies appear with beats
        if (counter > beatInterval &&gameManager.play)
        {
            counter = 0f;
            if (Random.Range(0.0f, 1.0f) < cutoff)
            {
                createVirus();
            }

            // 2. Move veggies as game progresses
            cutoff += 0.01f;
        }

    }

    void createVirus() {
        GameObject spot = spots[Random.Range(0, 6)];
        GameObject virus = viruses[Random.Range(0, 2)];
        Instantiate(virus, spot.transform.position, spot.transform.rotation);

    }
}
