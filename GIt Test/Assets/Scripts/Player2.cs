using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Player2
{
        public int hp; //ü��
        public int max_hp; //�ִ� ü��
        public int attack;  //����
        public int s_attack; //Ư�� ����
        public int shield; //���
        public int s_shield; //Ư�� ���
        public int spead;  //���ǵ�
        public string name;
        public Sprite image;  //sprite�� ����Ƽ���� 2D �̹��� ���Ͽ� ���� ����

        public void Attack() //������
        {
            Debug.Log($"{name}�� �������� �����ϴ�.");
            hp -= 20;
        }
        public void Shield() //������ ����
        {
            Debug.Log($"{name}�� ������ ��� ����մϴ�.");
            Debug.Log($"���� ü�� : {hp} / {max_hp}");
        }
        public void Heal()
        {
            if (hp >= max_hp)
            {
                Debug.Log("ü���� �̹� ���� �� �ֽ��ϴ�.");
                return;  //void �Լ����� return�� ����ϸ� �Լ��� ���Ḧ �ǹ��Ѵ�.
            }

            hp += 10;
            Debug.Log($"ü���� 10 ȸ���մϴ�! ���� ü�� {hp}/{max_hp}");
        }



    
}
