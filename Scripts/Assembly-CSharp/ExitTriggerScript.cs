using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020000BF RID: 191
public class ExitTriggerScript : MonoBehaviour
{
	public GameControllerScript gc;
	private void OnTriggerEnter(Collider other)
	{
        if (this.gc.notebooks >= 10 & other.tag == "Player")
        {
            if (GameObject.Find("BombPrefab(Clone)")) SceneManager.LoadScene("Results");
            else SceneManager.LoadScene("alt win");
        }
    }
}