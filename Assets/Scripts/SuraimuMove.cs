using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuraimuMove : MonoBehaviour
{
    //float step = 2f;// 移動速度
    private Vector3 target = new Vector3(0f, 0f, 0f);//中心を目的地に設定
    bool one;
    private GameObject refObj;
    public GameObject king;
    public GameObject Generator;

    // Use this for initialization
    void Start()
    {
        one = true;
        refObj = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update() 
    {
        if (SceneManager.GetActiveScene().name == "hard")
        {
            float step = 3.5f;// 移動速度
            Move(step);
        }
        else
        {
            float step = 3f;
            Move(step);
        }
        

        GameObject obj = getClickObject();
        if (obj != null)
        {
            // 以下オブジェクトがクリックされた時の処理
            Destroy(obj);
            if (obj.name == "princess")
            {
                Invoke("ChangeScene", 1.0f);
            }
        }



        SuraimuCount SC = refObj.GetComponent<SuraimuCount>();
        if (one == true)
        {
            if (Vector3.Distance(transform.position, target) < 0.01f) 
            {
                SC.SuraimuCnt++;
                one = false;
                Debug.Log(SC.SuraimuCnt);
            }
        }
        if (SC.SuraimuCnt >= 8)
        {
            Instantiate(king, new Vector3(0, 0, 0), Quaternion.identity);
            //one = false;
            SC.SuraimuCnt = 0;
            //Generator.SetActive(false);
            //GetComponent<Generate>().enabled = false;
            Invoke("ChangeScene", 1.0f);
        }
    }

    void Move(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
    }


    // 左クリックしたオブジェクトを取得する関数(2D)
    private GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
            if (collition2d)
            {
                result = collition2d.transform.gameObject;
            }
        }
        return result;
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("lose");
    }
}
