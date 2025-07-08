using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookTriggerExt : MonoBehaviour
{
    public GameObject Hook3d;
    public GameObject TriggerD;
    public void OnTriggerEnter()
    {
        Destroy(Hook3d);
    }
    public void OnTriggerExit()
    {
        Destroy(TriggerD);
    }
}
