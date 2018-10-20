using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHarm : MonoBehaviour {

    public GoombaController goomba;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activate()
    {
        goomba.Stomped();
    }
}
