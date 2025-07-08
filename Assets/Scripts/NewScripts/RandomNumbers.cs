using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumbers : MonoBehaviour
{
    private int Random2;
    public TMP_Text TextForBombz; 
    void Start()
    {
        Random2 = Random.Range(0, 10000);
        TextForBombz.text = Random2.ToString("0000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
