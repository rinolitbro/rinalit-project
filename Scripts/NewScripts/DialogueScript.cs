using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    public string Text;
    public string Text_2;
    public string Text_3;
    public string Text_Begin;
    public string NameTom;
    public string NameMan;
    public TMP_Text DialogueText;
    public TMP_Text NameText;
    public GameObject ManLeft;
    public GameObject ManRight;
    public int MouseClicked;
    public PlayerScript ps;
    public GameObject DialogueWindow;

    void OnEnable()
    {
        MouseClicked = 0;
        DialogueText.text = Text_Begin.ToString();
        NameText.text = NameMan.ToString();
        ManLeft.SetActive(true);
        ManRight.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
        {
            MouseClicked++;
        }
        if (Input.GetKeyDown(KeyCode.E) && Time.timeScale != 0f)
        {
            DialogueWindow.SetActive(false);
            ps.walkSpeed = 20f;
            ps.runSpeed = 22f;
        }
        switch (MouseClicked)
        {
            case 1:
                {
                    ManLeft.SetActive(false);
                    ManRight.SetActive(true);
                    DialogueText.text = Text.ToString();
                    NameText.text = NameTom.ToString();
                    break;
                }
            case 2:
                {
                    ManLeft.SetActive(true);
                    ManRight.SetActive(false);
                    DialogueText.text = Text_2.ToString();
                    NameText.text = NameMan.ToString();
                    break;
                }
            case 3:
                {
                    ManLeft.SetActive(false);
                    ManRight.SetActive(true);
                    DialogueText.text = Text_3.ToString();
                    NameText.text = NameTom.ToString();
                    break;
                }
            case 4:
                {
                    DialogueWindow.SetActive(false);
                    ps.walkSpeed = 20f;
                    ps.runSpeed = 28f;
                    break;
                }
        }

    }
}
