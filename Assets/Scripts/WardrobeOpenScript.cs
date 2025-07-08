using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeOpenScript : MonoBehaviour
{
	public Transform playerTransform;
	public Transform cameraTransform;
	public Animator DoorOpen;
	public AudioSource aud;
	public AudioClip Close;
	public int MouseClick;
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Wardrobe" & Vector3.Distance(playerTransform.position, transform.position) < 7))
			{
				MouseClick++;
				DoorOpen.SetBool("open", true);
			}
			if (MouseClick == 1)
            {
				aud.PlayOneShot(Close);
				DoorOpen.SetBool("open", false);
			}
			if (MouseClick == 2)
			{
				DoorOpen.SetBool("open", true);
				MouseClick = 0;
			}
		}
	}
}
