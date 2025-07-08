using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinyaRandomLocator : MonoBehaviour
{
    public AILocationSelectorScript wanderer;
    public Transform location;
    // Start is called before the first frame update
    void Start()
    {
        wanderer.FinyaPrikolist();
        transform.parent.position = location.position;
    }
}
