using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLever : MonoBehaviour
{
	public Transform playerTransform;
	public Transform cameraTransform;
	public MeshRenderer Wall;
	public Material LevelerOn;
	public Material LevelerOff;
	public AudioSource aud;
	public AudioClip pull;
	public bool levelup;
	public GameObject Trigger;
	void GetBool()
    {
		levelup = true;
		if (levelup == true)
		{
			Wall.material = LevelerOn;
			aud.PlayOneShot(pull);
			Invoke("NoTrigger", 0.1f);
		}
	}
	void NoTrigger()
    {
		Trigger.SetActive(false);
		levelup = false;
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Light" & Vector3.Distance(playerTransform.position, transform.position) < 7))
			{
				GetBool();
			}
		}
	}
}
