using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManDialogue : MonoBehaviour
{
	public PlayerScript ps;
	public GameObject Dialogue;
	public Transform playerTransform;
	public Transform cameraTransform;
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Joe" & Vector3.Distance(playerTransform.position, transform.position) < 7))
			{
				ps.walkSpeed = 0f;
				ps.runSpeed = 0f;
				Dialogue.SetActive(true);
			}
		}
	}
}
