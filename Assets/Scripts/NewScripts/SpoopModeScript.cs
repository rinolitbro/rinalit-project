using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoopModeScript : MonoBehaviour
{
    public GameControllerScript gc; 

    // Update is called once per frame
    void Update()
    {
        if (gc.notebooks == 1 & !gc.spoopMode) // If this is the players first notebook and they didn't get any questions wrong, reward them with a quarter
        {
            gc.ActivateSpoopMode();
        }
    }
}
