using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    //点数を表示するテクスト
    private GameObject pointText;

    private Text point;

    private int score=0;


    // Use this for initialization
    void Start () {
        //シーン中のPointTextオブジェクトを取得
        this.pointText = GameObject.Find("PointText");

        //PointTextに点数を表示
         point = pointText.GetComponent<Text>();

        //テキストの表示変更
        point.text = "Score" + score;
    }

    // Update is called once per frame
    void Update () {




    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
       string Tag = other.gameObject.tag;

        if (Tag == "SmallStarTag")
        {
            score += 5;
            point.text = "Score" + score;

        }
        else if (Tag == "LargeStarTag")
        {
            score +=  15;
            point.text = "Score" + score;

        }
        else if (Tag == "SmallCloudTag")
        {
            score += 10;
            point.text = "Score" + score;
        }
        else if (Tag == "LargeCloudTag")
        {
            score += 30;
            point.text = "Score" + score;
        }
    }
}
