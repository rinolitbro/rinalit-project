using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpTrigger : MonoBehaviour
{
    public Animator Text;
    public void OnTriggerStay()
    {
        Text.SetBool("Appear", true);
    }
    public void OnTriggerExit()
    {
        Text.SetBool("Appear", false);
    }
}
