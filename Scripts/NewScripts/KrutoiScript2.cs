using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KrutoiScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonPress(int value)
    {
        if (value >= 0 & value <= 9 & Limiter < 4)
        {
            this.playerAnswer.text = this.playerAnswer.text + value;
            Limiter++;
        }
        else if (value == -1)
        {
            this.playerAnswer.text = this.playerAnswer.text + "-";
        }
        else
        {
            this.playerAnswer.text = string.Empty;
            Limiter = 0;
        }
    }
    void Start()
    {
        rn = FindObjectOfType<RandomNumbers>();
        Timer = FindObjectOfType<GameControllerScript>().Timer;
    }
    public void CheckCode()
    {
        if (playerAnswer.text == rn.TextForBombz.text)
        {
            Timer.SetActive(true);
        }
        else
            print("Бабаха не будет");
    }
    public int Limiter;
    public TMP_Text playerAnswer;
    public RandomNumbers rn;
    public GameObject Timer;
}
