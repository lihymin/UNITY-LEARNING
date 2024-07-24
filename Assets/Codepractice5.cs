using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codepractice5 : MonoBehaviour
{
    Vector3 target = new Vector3(0, 0.5f, 0);

    Vector3 velo = Vector3.zero;
    void Update()
    {
        //목표 지점까지 이동하는 방법

        //1.MoveTowards(등속이동)
        transform.position = Vector3.MoveTowards(transform.position, target, 2.5f);

        //2.SmoothDamp(부드러운 이동(점점 감속 이동))
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1.2f);

        //3.Lerp(선형 보간, SmoothDamp보다 감속시간이 김)
        transform.position = Vector3.Lerp(transform.position, target, 0.5f);

        //4.Slerp (구면 선형 보간, 호를 그리며 이동)
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);
    }

    //델타타임
    //Time.deltaTime(벡터에 곱할 때, 시간 매개변수에 곱할 떄)
}
