using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changescene", 10);
    }

    void changescene()
    {
        SceneManager.LoadScene("Warning");
    }

}
