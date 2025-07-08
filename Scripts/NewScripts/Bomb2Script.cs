using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2Script : MonoBehaviour
{
	public GameObject BombHud;
	public Transform player;
	public GameControllerScript gc;

	void OnEnable()
    {
		player = FindObjectOfType<PlayerScript>().GetComponent<Transform>();
		gc = FindObjectOfType<GameControllerScript>().GetComponent<GameControllerScript>();
	}
		
	void Update()
    {
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Bomb" & Vector3.Distance(this.player.position, base.transform.position) < 7))
			{
				BombHud.SetActive(true);
				gc.PauseBombHud();
			}
		}
	}
}
