using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timer_text;
    public float time;
    void Start()
    {
        StartCoroutine(countDown());
        timer_text.text = time.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        timer_text.text = time.ToString();
        if (time == 0f)
        {
            SceneManager.LoadScene("DeathWin");
        }
    }
    IEnumerator countDown()
    {
        time--;
        yield return new WaitForSeconds(1);
        StartCoroutine(countDown());
        yield return null;
    }
}
