using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codepractice2 : MonoBehaviour
{
    int health = 10;
    string[] monsters = {"a","b","c","d"};
    int[] monstersLevel = {1,3,6,10};
    void Start()
    {   
        //6.반복문
        while (health > 0) {
            health--;
            Debug.Log("데미지를 입었습니다.");

            if (health == 0) {
                Debug.Log("죽었습니다.");
            }
        }

        for (int count = 0 ; count < 10 ; count++) {
            health++;
            Debug.Log("치료 중....");
        }

        foreach (string monster in monsters) {
            Debug.Log("맵에 있는 몬스터는: " + monster);
        }

        Heal();

        for (int index = 0; index < monsters.Length ; index++) {
            Debug.Log(Battle(monstersLevel[index]));
        }

        //8.클래스
        Class1 player = new Class1();
        player.id = 10000;
        Debug.Log(player.MyName(player.name));
    }

    //7.함수 (메소드)
    void Heal()
    {
        health += 10;
        Debug.Log("10만큼 회복되었습니다.");
    }

    string Battle(int monsterLevel)
    {
        int level = 4;
        string result;
        if (level >= monsterLevel) {
            result = "이겼습니다.";
        }
        else {
            result = "졌습니다.";
        }
        return result;
    }
}
