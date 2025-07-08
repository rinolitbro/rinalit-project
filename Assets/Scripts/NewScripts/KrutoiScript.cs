using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrutoiScript : MonoBehaviour
{
    public GameControllerScript gc;
    public GameObject BombHud;

    void OnEnable()
    {
        gc = FindObjectOfType<GameControllerScript>().GetComponent<GameControllerScript>();
    }
    public void Pisun2()
    {
        gc.UnpauseGame();
        BombHud.SetActive(false);
    }
}
