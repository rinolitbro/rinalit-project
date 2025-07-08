using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public AudioSource audioDevice;
    public AudioClip WaterSound;
    void Start()
    {
        Invoke("Update2", 30f);
    }

    // Update is called once per frame
    void Update2()
    {
        Destroy(transform.parent.gameObject);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC" || other.tag == "Player")
        {
            audioDevice.PlayOneShot(WaterSound);
        }
    }
}
