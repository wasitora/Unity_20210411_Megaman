using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    private void Start()
    {
        int NC = Camera.allCamerasCount;
        print("所有攝影機數量" + NC);

        Vector2 P2DG = Physics2D.gravity;
        print("2D的重力大小" + P2DG);

        Physics2D.gravity = new Vector2(0, -20);

        Vector2 P2DG2 = Physics2D.gravity;
        print("2D的重力大小" + P2DG2);

        //Application.OpenURL("http://unity3d.com/");

        Vector3 a = new Vector3(1, 1, 1);
        Vector3 b = new Vector3(22, 22, 22); 
        print ("距離" + Vector3.Distance(a, b));
    }

    private void Update()
    {
        //bool IAK = Input.anyKey;
        //print("是否輸入任意按鍵" + IAK);

        //float TimePass = Time.realtimeSinceStartup;
        //print("已經過時間"+ TimePass);


    }
}
