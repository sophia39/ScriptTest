using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss{
    private int mp = 54; //MPを宣言初期化
    //魔法用の関数
    public void Magic(){
        if (mp >= 5) {
             this.mp -= 5;//MP使用処理
             Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
        } else {
             Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
}
public class Test : MonoBehaviour {


    // Use this for initialization
    void Start () {
        //要素の個数が５の配列を初期化・代入する
        int[] array = {10, 20, 30, 50, 40};
        //配列の要素を順番に表示
        for (int i = 0; i < 5; i++){
            Debug.Log(array[i]);
        }
        //配列の要素を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Bossクラスの変数を宣言インスタンスを代入
        Boss boss = new Boss();

       
        //魔法を１１回使う
        for (int i = 0; i < 11; i++){
            //魔法用の関数呼び出し
            boss.Magic();
        }
 



    }

    // Update is called once per frame
    void Update () {
		
	}
}