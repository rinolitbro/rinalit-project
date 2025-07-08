using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookItemScript : MonoBehaviour
{
    public GameObject Hook3d;
    public GameObject TextHelp;
    public GameObject TriggerHelp;
    public GameObject HelpTextUI;
    public void Start()
    {
        TextHelp.SetActive(true);
        Destroy(TriggerHelp);
        Destroy(HelpTextUI);
    }
    public void HookAppear()
    {
        Hook3d.SetActive(true);
    }

}
