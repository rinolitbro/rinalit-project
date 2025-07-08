using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject BombPrefab;
    public Transform playerTransform;
    public Transform cameraTransform;
    void ResetBomb()
    {
        Bomb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(BombPrefab, playerTransform.position, cameraTransform.rotation);
            ResetBomb();
        }
    }
}
