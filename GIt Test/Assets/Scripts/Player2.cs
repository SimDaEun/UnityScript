using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Player2
{
        public int hp; //체력
        public int max_hp; //최대 체력
        public int attack;  //공격
        public int s_attack; //특수 공격
        public int shield; //방어
        public int s_shield; //특수 방어
        public int spead;  //스피드
        public string name;
        public Sprite image;  //sprite는 유니티에서 2D 이미지 파일에 대한 도구

        public void Attack() //물대포
        {
            Debug.Log($"{name}가 물대포를 쐈습니다.");
            hp -= 20;
        }
        public void Shield() //껍질에 숨기
        {
            Debug.Log($"{name}가 껍질에 숨어서 방어합니다.");
            Debug.Log($"현재 체력 : {hp} / {max_hp}");
        }
        public void Heal()
        {
            if (hp >= max_hp)
            {
                Debug.Log("체력이 이미 가득 차 있습니다.");
                return;  //void 함수에서 return만 사용하면 함수의 종료를 의미한다.
            }

            hp += 10;
            Debug.Log($"체력을 10 회복합니다! 현재 체력 {hp}/{max_hp}");
        }



    
}
