using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        EventCenter.AddListener(EventType.ShowText0, Show0);
        EventCenter.AddListener<string>(EventType.ShowText1, Show1);
        EventCenter.AddListener<string, float>(EventType.ShowText2, Show2);
        EventCenter.AddListener<string, float, int>(EventType.ShowText3, Show3);
        EventCenter.AddListener<string, float, int, string>(EventType.ShowText4, Show4);
        EventCenter.AddListener<string, float, int, string, int>(EventType.ShowText5, Show5);
    }

    private void OnDestroy()
    {
        EventCenter.RemoveListener(EventType.ShowText0, Show0);
        EventCenter.RemoveListener<string>(EventType.ShowText1, Show1);
        EventCenter.RemoveListener<string, float>(EventType.ShowText2, Show2);
        EventCenter.RemoveListener<string, float, int>(EventType.ShowText3, Show3);
        EventCenter.RemoveListener<string, float, int, string>(EventType.ShowText4, Show4);
        EventCenter.RemoveListener<string, float, int, string, int>(EventType.ShowText5, Show5);
    }

    public void Show0()
    {
        gameObject.SetActive(true);
    }

    public void Show1(string str)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str;
    }

    public void Show2(string str, float a)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str + a;
    }

    public void Show3(string str, float a, int b)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str + a + b;
    }

    public void Show4(string str, float a, int b, string str2)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str + a + b + str2;
    }

    public void Show5(string str, float a, int b, string str2, int c)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str + a + b + str2 + c;
    }
}
