using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codepractice4 : MonoBehaviour
{
    void Start()
    {
        int number = 5; //스칼라 값
        Vector2 dir = new Vector2(2, 0); //벡터 값

        transform.Translate(dir);
    }
    void Update()
    {
        //Input,KeyCode 클래스
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 움직였습니다.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 움직였습니다.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("발사 준비 완료!");

        if (Input.GetMouseButton(0))
            Debug.Log("에너지 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("발사!");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("점프 준비 완료!");

        if (Input.GetButton("Jump"))
            Debug.Log("기 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Horizontal"))
            Debug.Log("수평 이동 중... " + Input.GetAxisRaw("Horizontal"));

        if (Input.GetButton("Vertical"))
            Debug.Log("수직 이동 중... " + Input.GetAxisRaw("Vertical"));
    }
}
