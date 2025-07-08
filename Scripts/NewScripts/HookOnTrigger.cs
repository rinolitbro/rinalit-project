using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookOnTrigger : MonoBehaviour
{
    public HookItemScript hs;
    public GameObject ImageHookItem;
    public GameObject HelpText;
    public GameObject HookTrigger;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (GameObject.Find("ImageHookItem"))
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    hs.HookAppear();
                    Destroy(ImageHookItem);
                    Destroy(HelpText);
                    Destroy(HookTrigger);
                }
            }
        }
    }
}
