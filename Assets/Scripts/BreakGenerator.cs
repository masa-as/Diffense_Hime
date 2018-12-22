using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakGenerator : MonoBehaviour {
    private GameObject refObj;
    public GameObject Generator;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SuraimuCount SC = refObj.GetComponent<SuraimuCount>();
        if (SC.SuraimuCnt >= 8)
        {
            Generator.SetActive(false);
            //GetComponent<Generate>().enabled = false;
        }

    }
}
