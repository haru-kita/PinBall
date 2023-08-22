using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject score_object = null; //Textオブジェクト
    public int score_num = 0; // スコア変数

        //初期化
        void Start () {
        }

        //更新
        void Update () {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text> ();
        //テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;
        }

        //衝突
        void OnCollisionEnter(Collision collision) {
        //Debug.Log("当たった!");
        //score_num += 1; // 何かしらに当たれば1加算
        //ターゲットの種類によって得点を変える
            if (collision.gameObject.name == "SmallStar")
            {
                score_num += 1;
            }
            else if (collision.gameObject.name == "LargeStar")
            {
                score_num += 50;
            }
            else if(collision.gameObject.name == "SmallCloud")
            {
                score_num += 100;
            }
            else if(collision.gameObject.name == "LargeCloud")
            {
                score_num += 1000;
            }
        }
}