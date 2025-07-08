using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PaintingScript : MonoBehaviour
{
    public Image Painting;
    public Sprite[] Arts;
    int MouseClick;
    public TMP_Text CountText;
    int PaintedArt;
    public PlayerScript ps;
    void OnEnable()
    {
        MouseClick = 0;
        PaintedArt = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (MouseClick % 5 == 0 & MouseClick != 0)
        {
            PaintedArt++;
            MouseClick = 0;
        }
        if (PaintedArt == 3)
        {
            ps.DeactivateJumpRope();
        }
        if (Input.GetMouseButtonDown(0))
        {
            MouseClick++;
        }
        if (PaintedArt != 3)Painting.sprite = Arts[MouseClick + PaintedArt * 5];
        CountText.text = PaintedArt.ToString() + " / 3";
    }
}
