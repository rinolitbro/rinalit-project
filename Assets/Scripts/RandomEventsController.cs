using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomEventsController : MonoBehaviour
{
    public int EventSelect;
    public bool KeepSelect;
    void KeepSelecting()
    {
        EventSelect = Random.Range(0, 10);
        Invoke("KeepSelecting", 10f);
    }
    void FixedUpdate()
    {
        if (KeepSelect == true)
        {
            KeepSelecting();
        }
    }
    void TurnOnBool()
    {
        KeepSelect = true;
        Invoke("KeepSelecting", 10f);
    }
    void Event1()
    {
        //zdec tipo budet event;
    }
    void Event2()
    {
        //zdec tipo budet event;
    }
    void Event3()
    {
        //zdec tipo budet event;
    }
    void Update()
    {
        if (EventSelect == 1)
        {
            Event1();
            KeepSelect = false;
            Invoke("TurnOnBool", 50f);
            print("EVENT 1");
        }
        if (EventSelect == 2)
        {
            Event2();
            KeepSelect = false;
            Invoke("TurnOnBool", 50f);
            print("EVENT 2");
        }
        if (EventSelect == 3)
        {
            Event3();
            KeepSelect = false;
            Invoke("TurnOnBool", 50f);
            print("EVENT 3");
        }
    }
}
