using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement2 : MonoBehaviour
{

    private Transform vrCamera;
    public float speed = 3f;
    CharacterController myCC;

    public bool isWalking = false;
    public float jumpSpeed = 8.0F;
    bool isOpen;

    // Use this for initialization
    void Start()
    {
        myCC = gameObject.GetComponent<CharacterController>();
        vrCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        myCC.SimpleMove(speed * vrCamera.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal")));

    }
}
