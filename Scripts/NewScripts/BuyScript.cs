using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour
{
    public int[] Price;
    public TMP_Text PriceText;
    public Image ItemImage;
    public int ID;
    public Sprite[] ItemSprites;
    public GameControllerScript gc;
    public int Price2;
    public GameObject TextSoldOut;
    public AudioSource audioDevice;
    public AudioClip nah;
    public AudioClip good;
    void Start()
    {
        ID = Random.Range(1, 11);
        Price2 = Price[ID];
        ItemImage.sprite = ItemSprites[ID];
        PriceText.text = "Cost: " + Price2.ToString();
    }
    public void Buy()
    {
        if (gc.score >= Price2)
        {
            gc.CollectItem(ID);
            gc.score -= Price2;
            Destroy(gameObject);
            audioDevice.Stop();
            audioDevice.PlayOneShot(good);
            TextSoldOut.SetActive(true);
        }
        else
        {
            audioDevice.Stop();
            audioDevice.PlayOneShot(nah);
        }
    }
}
