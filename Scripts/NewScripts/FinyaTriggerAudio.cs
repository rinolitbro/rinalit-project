using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinyaTriggerAudio : MonoBehaviour
{
    public AudioClip hello;
    public AudioSource audioDevice;
    public Animator finya;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioDevice.Stop();
            audioDevice.PlayOneShot(hello);
        }
    }

    void Update()
    {
        if(audioDevice.isPlaying)
            finya.SetBool("talk", true);
        else
            finya.SetBool("talk", false);
    }
}
