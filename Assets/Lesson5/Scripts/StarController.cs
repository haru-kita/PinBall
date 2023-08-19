using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

        // 回転速度の変数rotSpeedを作成
        private float rotSpeed = 0.5f;

        // Start is called before the first frame update
        void Start ()
        {
                //開始時の回転値
                this.transform.Rotate (0, Random.Range (0, 360), 0);
        }

        // Update is called once per frame
        void Update ()
        {
                //回転させる
                this.transform.Rotate (0, this.rotSpeed, 0);
        }
}