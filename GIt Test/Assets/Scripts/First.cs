using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // (Ȱ��ȭ) ����Ƽ ������ �ִ� ����� ����Ѵ�.

public class First : MonoBehaviour  //MonoBehaviour�� ����Ǿ��ִ�.
//MonoBehaviour�� ����Ƽ���� ����ϴ� �ʼ� ��ɵ��� ��Ƴ��� Ŭ�����̴�.
//MonoBehaviour�� ����Ǿ� ���� ������ ����Ƽ�� ������Ʈ�� ������ �� ����.
{
    //�Ϲ� C#������ Main�Լ��� ���� ������ �����ߴٸ�, 
    //����Ƽ�� ��ũ��Ʈ�� ������ ����Ŭ�� ���� ������ ��ġ�� �ڵ带 �����ϰ� 
    //����Ƽ ������ �����ϴ� ������ �۾��� �����Ѵ�.

    public int count = 0;          //����Ƽ �������� ������ �����ϰ� ����
    private float value = 2.0f;    //����Ƽ �������� ������ �Ұ����ϰ� ������ �ʴ´�.

    // Start is called before the first frame update
    // ù ������ ���� �� ȣ��Ǵ� �Լ�
    void Start()
    {
        Debug.Log("ù �����ӿ��� Start�� �����ϰڽ��ϴ�!");
    }

    // Update is called once per frame
    // �������� ���� ���� �����ؾ��ϴ� ��ġ (�� �����Ӹ��� ��� �����)
    // �ٽ� ���� ���� �ۼ��Ǵ� ��ġ
    // ��� �ݺ��Ѵ�.
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
