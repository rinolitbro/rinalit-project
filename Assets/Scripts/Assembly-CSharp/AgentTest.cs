using System;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020000C7 RID: 199
public class AgentTest : MonoBehaviour
{
	// Token: 0x06000999 RID: 2457 RVA: 0x0002431D File Offset: 0x0002271D
	private void Start()
	{
		this.agent = base.GetComponent<NavMeshAgent>(); // Define the AI Agent
		this.Wander(); //Start wandering
		coolDown2 = 30f;
		agent.speed = 15f;

	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00024331 File Offset: 0x00022731
	private void Update()
	{
		if (this.coolDown > 0f)
		{
			this.coolDown -= 1f * Time.deltaTime;
		}
		if (coolDown2 > 0f)
		{
			coolDown2 -= 2f * Time.deltaTime;
		}
		if (coolDown2 < 0f && Fixer == false)
		{
			MentalBreakDown();
		}
		Vector3 direction = this.player.position - base.transform.position;
		RaycastHit raycastHit;
		if (Physics.Raycast(base.transform.position, direction, out raycastHit, float.PositiveInfinity, 769, QueryTriggerInteraction.Ignore) & raycastHit.transform.tag == "Player")
		{
			PlayerSee = true;
		}
		else
        {
			PlayerSee = false;
			
        }
		Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
		RaycastHit Hit;
		if (Physics.Raycast(ray, out Hit) && (Hit.transform.tag == "FlySmoke") & Vector3.Distance(this.player.position, Hit.transform.position) < 52)
        {
			if (FlySmokeAFK && PlayerSee)
            {
					print("you're staring at him.");
			}
		}
		else
        {
			if (FlySmokeAFK && PlayerSee && !PlayerSlowness)
            {
				Update4();
				SecretWay();
				print("you lost him");
				Bang.SetBool("BOOM", true);
			}
		}
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x0002435C File Offset: 0x0002275C
	private void FixedUpdate()
	{
		Vector3 direction = this.player.position - base.transform.position;
		RaycastHit raycastHit;
		if (Physics.Raycast(base.transform.position, direction, out raycastHit, float.PositiveInfinity, 3, QueryTriggerInteraction.Ignore) & raycastHit.transform.tag == "Player") //Check if its the player
		{
			this.db = true;
		}
		else
		{
			this.db = false;
			if (this.agent.velocity.magnitude <= 1f & this.coolDown <= 0f)
			{
				this.Wander(); //Just wander
			}
		}
	}


	// Token: 0x0600099C RID: 2460 RVA: 0x0002440D File Offset: 0x0002280D
	private void Wander()
	{
		this.wanderer.GetNewTarget(); //Get a new target on the map
		this.agent.SetDestination(this.wanderTarget.position); //Set its destination to position of the wanderTarget
		this.coolDown = 1f;
	}

	public void MentalBreakDown()
    {
		FlySmokeAFK = true;
		FlySmoke.sprite = BreakDown;
		agent.speed = 0f;
		FlySound.Play();
		Fixer = true;
	}
	void Update4()
    {
		PlayerSlowness = true;
		ps.walkSpeed = 5f;
		ps.runSpeed = 6f;
		FlySound2.PlayOneShot(smash);
		Invoke("Update5", 10f);
	}
	void Update5()
    {
		PlayerSlowness = false;
		ps.walkSpeed = 20f;
		ps.runSpeed = 22f;
		Bang.SetBool("BOOM", false);
	}
	public void SecretWay()
    {
		FlySmoke.sprite = Default;
		agent.speed = 15f;
		FlySound.Stop();
		Wander();
		coolDown2 = 30f;
		FlySmokeAFK = false;
		Fixer = false;
	}



	// Token: 0x04000676 RID: 1654
	public bool db;

	// Token: 0x04000677 RID: 1655
	public Transform player;

	// Token: 0x04000678 RID: 1656
	public Transform wanderTarget;

	// Token: 0x04000679 RID: 1657
	public AILocationSelectorScript wanderer;

	// Token: 0x0400067A RID: 1658
	public float coolDown;

	public float coolDown2;

	// Token: 0x0400067B RID: 1659
	public NavMeshAgent agent;

	public SpriteRenderer FlySmoke;
	public Sprite Default;
	public Sprite BreakDown;
	public AudioSource FlySound;
	public AudioSource FlySound2;
	public AudioClip Ambience;
	public AudioClip smash;

	public bool PlayerSee;
	public bool FlySmokeAFK;
	public PlayerScript ps;
	bool PlayerSlowness;
	public Animator Bang;
	bool Fixer;
}
