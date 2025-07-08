using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }

}
