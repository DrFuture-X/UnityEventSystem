using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnClick : MonoBehaviour
{
    private Button noParameter;
    private Button oneParameter;
    private Button twoParameter;
    private Button threeParameter;
    private Button fourParameter;
    private Button fiveParameter;
    private void Awake()
    {
        noParameter = transform.Find("NoParameter").GetComponent<Button>();
        oneParameter = transform.Find("OneParameter ").GetComponent<Button>();
        twoParameter = transform.Find("TwoParameter").GetComponent<Button>();
        threeParameter = transform.Find("ThreeParameter").GetComponent<Button>();
        fourParameter = transform.Find("FourParameter").GetComponent<Button>();
        fiveParameter = transform.Find("FiveParameter").GetComponent<Button>();
    }

    private void Start()
    {
        noParameter.onClick.AddListener(()=>
        {
            EventCenter.Broadcast(EventType.ShowText0);
        });

        oneParameter.onClick.AddListener(() =>
        {
            EventCenter.Broadcast(EventType.ShowText1, "你好1");
        });

        twoParameter.onClick.AddListener(() =>
        {
            EventCenter.Broadcast(EventType.ShowText2, "你好1", 2.0f);
        });

        threeParameter.onClick.AddListener(() =>
        {
            EventCenter.Broadcast(EventType.ShowText3, "你好1", 2.0f, 3);
        });

        fourParameter.onClick.AddListener(() =>
        {
            EventCenter.Broadcast(EventType.ShowText4, "你好1", 2.0f, 3, "吗？4");
        });

        fiveParameter.onClick.AddListener(() =>
        {
            EventCenter.Broadcast(EventType.ShowText5, "你好1", 2.0f, 3, "吗？4", 5);
        });
    }
}
