using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
    bool one = true;
    Vector3 target = new Vector3(0, 0, 0);
    public GameObject suraimu;
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float cahngeBlue = 1.0f;
    float cahngeAlpha = 1.0f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (one == true)
        {
            if (Vector3.Distance(suraimu.transform.position, target) < 0.01f)
            {
                changeRed = 1.0f;
                changeGreen = 0.0f;
                cahngeBlue = 0.0f;
                cahngeAlpha = 1.0f;
                // 元の画像の赤色のデータのみで表示される。
                this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
                one = false;
            }
        }

    }
}
