using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // (활성화) 유니티 엔진에 있는 기능을 사용한다.

public class First : MonoBehaviour  //MonoBehaviour가 연결되어있다.
//MonoBehaviour은 유니티에서 사용하는 필수 기능들을 모아놓은 클래스이다.
//MonoBehaviour에 연결되어 있지 않으면 유니티의 오브젝트에 연결할 수 없다.
{
    //일반 C#에서는 Main함수를 통해 실행을 진행했다면, 
    //유니티의 스크립트는 라이프 사이클에 의해 정해진 위치에 코드를 설계하고 
    //유니티 엔진을 실행하는 것으로 작업을 진행한다.

    public int count = 0;          //유니티 엔진에서 수정이 가능하고 보임
    private float value = 2.0f;    //유니티 엔진에서 수정이 불가능하고 보이지 않는다.

    // Start is called before the first frame update
    // 첫 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log("첫 프레임에서 Start를 시작하겠습니다!");
    }

    // Update is called once per frame
    // 실질적인 동작 등을 구현해야하는 위치 (매 프레임마다 계속 실행됨)
    // 핵심 로직 등이 작성되는 위치
    // 계속 반복한다.
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
