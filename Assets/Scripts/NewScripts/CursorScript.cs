using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorScript : MonoBehaviour
{
    Image curImg;
    public Sprite[] curSpr = new Sprite[2];
    // Start is called before the first frame update
    void Start()
    {
        curImg = GetComponent<Image>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            curImg.sprite = curSpr[0];
            Invoke("f", 0.1f);
        }
    }
    void f()
    {
        curImg.sprite = curSpr[1];
    }
}