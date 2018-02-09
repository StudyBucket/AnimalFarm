using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class SoundFiles : MonoBehaviour
{
    public GameObject obj, player;
    private bool looking;
    public float minDistance = 10.0f;
    private float distance;

    public AudioClip myclip;

    // Use this for initialization
    void Start()
    {
        looking = false;

        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.myclip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {

        if (looking)
        {
            if (distance <= minDistance)
            {


                if (Input.GetButtonDown("Fire1"))
                {
                    this.GetComponent<AudioSource>().Play();
                }
            }
        }
    }

    #region IGvrGazeResponder implementation

    public void OnGazeEnter()
    {
        looking = true;
    }
    public void OnGazeExit()
    {
        looking = false;
    }
    public void OnGazeTrigger()
    {
        looking = true;

    }
    #endregion
}
