using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Menu menu;

    private void OnEnable()
    {
        menu.events.zeroParaEvent.AddListener(ZeroPare);
        menu.events.oneParaEvent.AddListener(OnePara);
        menu.events.twoParaEvent.AddListener(TwoPara);
        menu.events.threeParaEvent.AddListener(ThreePara);
    }

    private void OnDisable()
    {
        menu.events.zeroParaEvent.RemoveListener(ZeroPare);
        menu.events.oneParaEvent.RemoveListener(OnePara);
        menu.events.twoParaEvent.RemoveListener(TwoPara);
        menu.events.threeParaEvent.RemoveListener(ThreePara);
    }

    private void ZeroPare()
    {
        Debug.Log("û�в���");
    }

    private void OnePara(int x)
    {
        Debug.Log("һ�������������ǣ�" + x);
    }

    private void TwoPara(int x, string s)
    {
        Debug.Log("���������������ǣ�" + x + "��" + s);
    }

    private void ThreePara(int x, string s, float f)
    {
        Debug.Log("���������������ǣ�" + x + "��" + s + "��" + f);
    }
}
