using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codepractice3 : MonoBehaviour
{
    void Awake()
    {
        //처음 초기화 할 때 제일 먼저 실행되는 함수
        Debug.Log("게임이 시작되었습니다.");
    }

    void OnEnable()
    {
        //활성화 될 떄
        Debug.Log("로그인하였습니다.");
    }
    void Start()
    {
        //처음 초기화 할 떄 실행되는 함수
        Debug.Log("장비를 챙기세요.");
    }

    void FixedUpdate()
    {
        //1초에 50번/물리 연산과 관련된 로직
        Debug.Log("이동~");
    }

    void Update()
    {
        //CPU환경에 따라 fps가 달라질 수 있음(일반적으로 60fps)/물리 연산 로직 이외 나머지 게임안에서 끊임없이 실행되는 (주기적으로 변하는) 로직을 넣어야 함.
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate()
    {
        //업데이트 영역 함수가 모두 끝난 후 실행되는 함수/로직의 후처리(ex)움직이는 캐릭터(FixedUpdate)를 따라가는 카메라(LateUpdate))
        Debug.Log("경험치 흭득!");
    }

    void OnDisable()
    {   
        //비활성화 될 때
        Debug.Log("로그아웃하였습니다.");
    }

    void OnDestroy()
    {
        //삭제될 떄 실행되는 함수
        Debug.Log("데이터 삭제 완료!");
    }
}
