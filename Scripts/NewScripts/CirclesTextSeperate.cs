using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CirclesTextSeperate : MonoBehaviour
{
    public GameControllerScript gc;
    public TMP_Text scoreText;
    void Update()
    {
        scoreText.text = gc.score.ToString() + " Circles";
    }
}
