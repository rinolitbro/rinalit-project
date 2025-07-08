using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceBreak : MonoBehaviour
{
    public Transform player;
	public MeshRenderer Fence;
	public Material FenceBroken;
	public MeshCollider Mesh;
	public GameObject Axe;
	public GameObject trigger;
	public AudioSource fenceAudio;
	public AudioClip Broken;

	void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Fence" & Vector3.Distance(this.player.position, base.transform.position) < 7))
			{
				Fence.material = FenceBroken;
				Mesh.enabled = false;
				Axe.SetActive(false);
				Destroy(trigger);
				fenceAudio.PlayOneShot(Broken);
			}
		}
	}
}
