using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinyaIsTalking : MonoBehaviour
{
    public AudioSource audioDevice;
    public Animator FinyaSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (audioDevice.isPlaying)
            FinyaSprite.SetBool("talk", true);
        else
            FinyaSprite.SetBool("talk", false);
    }
}
