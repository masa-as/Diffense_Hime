using UnityEngine;
using System.Collections;

// 自動で消える
public class DeleteSlashing : MonoBehaviour
{
    public float timer = 0.5f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}