using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseButtonScript : MonoBehaviour
{
    bool active;
    public GameObject rino;

    public void Start3()
    {
        if (active)
        {
            active = false;
            rino.SetActive(!active);
        }
        else
        {
            active = true;
            rino.SetActive(!active);
        }
    }
}
