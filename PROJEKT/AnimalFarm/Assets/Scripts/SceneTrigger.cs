using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger : MonoBehaviour {

    public PlayableDirector director;
    public GameObject obj, player, timeline;
    private bool looking;
    public float minDistance = 10.0f;
    private float distance;

    // Use this for initialization
    void Start () {
        looking = false;
    }
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.transform.position, obj.transform.position);

        if (looking)
        {
            if (distance <= minDistance)
            {


                if (Input.GetButtonDown("Fire1"))
                {
                    director = timeline.GetComponent<PlayableDirector>();

                    if(director != null)
                    {
                        director.Play();
                    }
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
