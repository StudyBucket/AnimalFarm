using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class Interaction : MonoBehaviour {
    public GameObject Flasche,Testflasche,player;
    private bool looking ;
    public float minDistance = 10.0f;
    private float distance;
    public bool carry;

    // Use this for initialization
    void Start () {
        looking = false;
        carry = false;

        Testflasche.SetActive(true);
        Flasche.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, Testflasche.transform.position);
  
        if (looking)
        {
            if (distance <= minDistance)
            {

                
                if (Input.GetButtonDown("Fire1"))
                {

                    Testflasche.SetActive(false);
                    Flasche.SetActive(true);
                    carry = true;
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
