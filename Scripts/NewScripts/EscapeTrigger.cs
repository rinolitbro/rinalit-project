using UnityEngine.SceneManagement;
using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Escape");
        }
    }
}