using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IchorScript : MonoBehaviour
{
    public GameObject Ichor;
    public PlayerScript ps;
    void OnEnable()
    {
        ps.walkSpeed = 5f;
        ps.runSpeed = 6f;
        Invoke("Update3", 5f);
    }

    // Update is called once per frame
    void Update3()
    {
        Ichor.SetActive(false);
        ps.walkSpeed = 20f;
        ps.runSpeed = 28f;
    }
}
