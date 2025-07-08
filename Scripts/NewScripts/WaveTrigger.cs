using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveTrigger : MonoBehaviour
{
    public Animator RinolitAnim;
    public AudioSource aud;
    public AudioClip Hello;
    public GameObject Trigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            RinolitAnim.SetTrigger("Wave");
        Destroy(Trigger);
        aud.PlayOneShot(Hello);
    }
}
