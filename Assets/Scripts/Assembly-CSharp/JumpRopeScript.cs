﻿using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class JumpRopeScript : MonoBehaviour
{
	// Token: 0x06000048 RID: 72 RVA: 0x000033A4 File Offset: 0x000017A4
	private void OnEnable()
	{
		this.jumpDelay = 1f;
		this.ropeHit = true;
		this.jumpStarted = false;
		this.jumps = 0;
		this.jumpCount.text = 0 + "/3";
		this.cs.jumpHeight = 5f;
		this.playtime.audioDevice.PlayOneShot(this.playtime.aud_ReadyGo);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003418 File Offset: 0x00001818
	private void Update()
	{
		if (this.jumpDelay > 0f) //Decrease jumpDelay countdown
		{
			this.jumpDelay -= Time.deltaTime;
		}
		else if (!this.jumpStarted) //If the jump hasn't started
		{
			this.jumpStarted = true; //Start the jump
			this.ropePosition = 1f; //Set the rope position to 1f;
			this.ropeHit = false;
		}
		if (this.ropePosition > 0f)
		{
			this.ropePosition -= Time.deltaTime;
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000034F0 File Offset: 0x000018F0
	private void Success()
	{
		this.playtime.audioDevice.Stop(); //Stop all of the lines playtime is currently speaking
		this.playtime.audioDevice.PlayOneShot(this.playtime.aud_Numbers[this.jumps]);
		this.jumps++;
		this.jumpCount.text = this.jumps + "/3";
		this.jumpDelay = 0.5f;
		if (this.jumps >= 3) //If players complete the minigame
		{
			this.playtime.audioDevice.Stop(); //Stop playtime from talking
			this.playtime.audioDevice.PlayOneShot(this.playtime.aud_Congrats);
			this.ps.DeactivateJumpRope(); //Deactivate the jumprope
		}
	}

	// Token: 0x04000058 RID: 88
	public TMP_Text jumpCount;

	// Token: 0x04000059 RID: 89
	public Animator rope;

	// Token: 0x0400005A RID: 90
	public CameraScript cs;

	// Token: 0x0400005B RID: 91
	public PlayerScript ps;

	// Token: 0x0400005C RID: 92
	public PlaytimeScript playtime;

	// Token: 0x0400005E RID: 94
	public int jumps;

	// Token: 0x0400005F RID: 95
	public float jumpDelay;

	// Token: 0x04000060 RID: 96
	public float ropePosition;

	// Token: 0x04000061 RID: 97
	public bool ropeHit;

	// Token: 0x04000062 RID: 98
	public bool jumpStarted;

	public SpriteRenderer Painting;
}
