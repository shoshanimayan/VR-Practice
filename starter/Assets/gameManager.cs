using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public static bool play;
    public static bool ended;
    public Text scoreMessage;
    public Text message;
    private int score;
    public static int weapons;
    private AudioSource AS;
    public AudioClip hit;
    public AudioClip gun;
    private void Awake()
    {
        AS = GetComponent<AudioSource>();
        weapons = 0;
        play = false;
        ended = false;
        scoreMessage.text = "Score: " + score.ToString();
    }
    public void increaseScore() {
        if (play) {
            score++;
            scoreMessage.text = "Score: " + score.ToString();
        }

    }
    public void end() {
        ended = true;
        play = false;
    }

    public void hitSound() {
        AS.PlayOneShot(hit);
    }
    public void gunSound() {
        AS.PlayOneShot(gun);
    }

    private void Update()
    {
        if (!ended && weapons >= 2) {
            message.enabled = false;
            play = true;


        }
        if (ended) {
            message.text = "you missed to many and lost\n hit trigger restart.";
            message.enabled = true;
        }

    }

}
