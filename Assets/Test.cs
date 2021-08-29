using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    public class Boss
    {
        private int mp = 53;
        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }
    }
    // Use this for initialization
    void Start()
    {
        int[] points = new int[5];
        // 配列の各要素に値を代入する
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;
        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(points[i]);
        }
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        // 11回処理を繰り返す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}