using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoopModeTrigger : MonoBehaviour
{
    public GameControllerScript gc;
    public AudioSource aud;
    public AudioClip Hey;
    public GameObject Trigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            aud.PlayOneShot(Hey);
            Invoke("DestroyTrigger", 4f);
            gc.ActivateSpoopMode();
    }
    void DestroyTrigger()
    {
        Destroy(Trigger);
    }
}
