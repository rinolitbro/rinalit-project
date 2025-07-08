using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorPopUp : MonoBehaviour
{
    Image Cursor;
    public Transform player;
    void Start()
    {
        Cursor = GetComponent<Image>();
    }
    void CursorPopUp2(bool skibidi)
    {
        Cursor.enabled = skibidi;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
        RaycastHit raycastHit;
        if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Notebook" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 10))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Door" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 15))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Item" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 10))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Bomb" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 7))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Shop" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 7))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Axe" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 7))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Fence" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 7))
            CursorPopUp2(true);
        else if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Joe" & Vector3.Distance(this.player.position, raycastHit.transform.position) < 7))
            CursorPopUp2(true);
        else 
            CursorPopUp2(false);
    }
}
