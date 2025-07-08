using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{

    private CharacterController cc;

    [SerializeField] private float gravity;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 grav = Vector3.zero;

        if (!cc.isGrounded)
        {
            grav.y -= gravity * Time.deltaTime;
        }

        cc.Move(grav * Time.deltaTime);
    }
}