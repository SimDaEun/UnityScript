using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class second : MonoBehaviour
{
    //텍스트 컴포넌트에 ID,lever,exp에 대한 내용을 스크립트 작업을 통해 넣어줍니다.
    public Text id_text;
    public Text level_text;
    public Text exp_text;

    public string id;

    [Range(1,99)] public int level;
    //유니티 인스펙터에서 1에서 99사이의 범위를 선택할 수 있다. (휠 바)

    [Range(0, 100.0f)] public float exp;

    private void Start()
    {
        id_text.text = id;
        level_text.text = level.ToString();
        exp_text.text = exp.ToString();
    }

    private void Update()
    {
        
    }
}
