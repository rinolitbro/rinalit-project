using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAnimationScript : MonoBehaviour
{
    public float modifier;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, Mathf.Sin(Time.time * modifier)));
    }
}
