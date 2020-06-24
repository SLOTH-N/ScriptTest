using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Magic()
    {
        
        if(mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp +"。");
        }
    }
    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour {
    int[] array = {5,7,7,8,100};
    
    // Use this for initialization
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        for (int m = 0; m<11;m++)
        {
           
            lastboss.Magic();
        }
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        for (int i = 0; i<array.Length; i++)
        {
            Debug.Log(array[i]);
            Debug.Log(array[4 - i]);
        }
        
    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
