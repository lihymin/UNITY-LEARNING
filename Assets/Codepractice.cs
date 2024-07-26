using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codepractice : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수
        int level = 100;
        float strength = 15.5f;
        string playerName = "검사";
        bool isFullLevel = false;

        Debug.Log(playerName);

        //2.그룹형 변수(배열,리스트)
        string[] monsters = {"a", "b", "c", "d"};

        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 3;
        monsterLevel[2] = 6;

        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("회복물약10");
        
        Debug.Log(items[0]);

        //3.연산자
        int exp = 1500;

        exp += 320;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log(exp);
        Debug.Log(level);
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log(isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log(isEndTutorial);

        int health = 30;
        int mana = 25;
        bool isBadCondition = health < 50 || mana <= 20;
        Debug.Log(isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log(condition);

        //4.키워드
        //int,string 등 프로그래밍 언어들은 값이나 변수이름으로 못 씀

        //5.조건문
        if (condition == "나쁨") {
            Debug.Log("회복물약을 써주세요.");
        }
        else {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }
        if (isBadCondition && items[0] == "회복물약10") {
            items.RemoveAt(0);
            health += 10;
            Debug.Log("채력이 10증가하였습니다.");
        }

        switch (monsters[1]) {
            case "a":
            case "b":
                Debug.Log("a,b라는 몬스터가 소환됐습니다.");
                break;
            case "c":
                Debug.Log("c라는 몬스터가 소환됐습니다.");
                break;
            default:
                Debug.Log("특수 몬스터가 소환됐습니다.");
                break;
        }

    }

}
