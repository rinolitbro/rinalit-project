using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInteract : MonoBehaviour
{
	public GameObject ShopHud;
	public GameControllerScript gc;
	public Transform player;
	void Update()
    {
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Shop" & Vector3.Distance(this.player.position, base.transform.position) < 7))
			{
				ShopHud.SetActive(true);
				gc.ShopPause();
			}
		}
	}
}
