using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpackcontroller : MonoBehaviour
{
    public GameControllerScript gc;
    public GameObject Bomb;
    public GameObject Hook;

    public void BombTake()
    {
			Bomb.SetActive(true);
            gc.UnpauseBackpack();
    }
    public void HookTake()
    {
        Hook.SetActive(true);
        gc.UnpauseBackpack();
    }
}
