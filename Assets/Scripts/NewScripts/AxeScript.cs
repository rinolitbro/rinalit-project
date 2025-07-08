using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public GameObject Axe;
	public GameObject AxeHud;
	public Transform playerTransform;
	public Transform cameraTransform;
	public GameObject Trigger;
	public void NoAxe()
    {
		Destroy(Axe);
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Axe" & Vector3.Distance(playerTransform.position, transform.position) < 7))
			{
				AxeHud.SetActive(true);
				NoAxe();
				Trigger.SetActive(true);
			}
		}
	}
}
