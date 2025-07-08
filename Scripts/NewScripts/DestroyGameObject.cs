using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public void Start2()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    public void Start3()
    {
        gameObject.SetActive(false);
    }
}
