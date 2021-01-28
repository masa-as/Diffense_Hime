using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Generate : MonoBehaviour
{
    //プレハブを変数に代入
    public GameObject suraimu;
    public GameObject suraimu_b;

    private void Start()
    {
        StartCoroutine(FuncCaller());
    }

    private void Update()
    {

    }

    IEnumerator FuncCaller()
    {
        while (true)
        {
            if (SceneManager.GetActiveScene().name == "hard")
            {
                //１秒待つ
                yield return new WaitForSecondsRealtime(0.5f);
                SuraimuGenerator();
            }
            else
            {
                //１秒待つ
                yield return new WaitForSecondsRealtime(1.0f);
                SuraimuGenerator();
            }
        }
    }
    void SuraimuGenerator()
    {

        //ランダムな座標を生成
        float x = Random.Range(-10.0f, 3.0f);
        if (-3 <= x && x <= 3)
        {
            x = x + 7;
        }
        float y = Random.Range(-5.0f, -2.0f);
        if (-3 <= y && y <= -2)
        {
            y = y + 7;
        }
        float z = 0.0f;
        Instantiate(suraimu, new Vector3(x, y, z), Quaternion.identity);

        // 確率でスライムベスを生成
        // スライムベスは行動が早いなどの設定ができると良い
        // float probability = Random.Range(0, 100.0f);
        // if (probability > 80.0f)
        // {
        //    //スライムを生成
        //    Instantiate(suraimu, new Vector3(x, y, z), Quaternion.identity);
        // }
        // else
        // {
        //    //スライムベスを生成
        //    Instantiate(suraimu_b, new Vector3(x, y, z), Quaternion.identity);
        // }
    }
}