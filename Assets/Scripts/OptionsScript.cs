using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001B RID: 27
public class OptionsScript : MonoBehaviour
{
	// Token: 0x06000061 RID: 97 RVA: 0x000037B4 File Offset: 0x00001BB4
	private void Start()
	{
		if (PlayerPrefs.HasKey("OptionsSet"))
		{
			this.slider.value = PlayerPrefs.GetFloat("MouseSensitivity");
		}
		else
		{
			PlayerPrefs.SetInt("OptionsSet", 1);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003850 File Offset: 0x00001C50
	private void Update()
	{
		PlayerPrefs.SetFloat("MouseSensitivity", this.slider.value);
	}

	// Token: 0x0400006F RID: 111
	public Slider slider;

	// Token: 0x04000070 RID: 112

}
