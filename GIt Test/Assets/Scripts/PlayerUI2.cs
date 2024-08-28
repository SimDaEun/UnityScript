using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI2 : MonoBehaviour
{
    public Player2 player2;

    public Image Player_Image;

    public Slider player_hp;
    public Slider Player_attack;
    public Slider Palyer_shield;
    public Slider Palyer_S_shield;
    public Slider Palyer_S_attack;
    public Slider Palyer_speed;

    public Text player_name;
    public GameObject player_UI;

    public void Action01()
    {
        player2.Attack();
    }

    public void Action02()
    {
        player2.Shield();
    }

    public void Action03()
    {
        player2.Heal(); //플레이어의 회복 기능 사용
        setValue(); //체력 최신화
    }

    public void setValue()
    {
        player_hp.value = player2.hp;
    }
}
