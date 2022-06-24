using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public Button zeroBt;
    public Button oneBt;
    public Button twoBt;
    public Button threeBt;

    public Events events;

    private void Start()
    {
        zeroBt.onClick.AddListener(() =>
        {
            events.zeroParaEvent.Invoke();
        });

        oneBt.onClick.AddListener(() =>
        {
            int x = 10;
            events.oneParaEvent.Invoke(x);
        });

        twoBt.onClick.AddListener(() =>
        {
            int x = 10;
            string s = "ÄãºÃÑ½";
            events.twoParaEvent.Invoke(x, s);
        });

        threeBt.onClick.AddListener(() =>
        {
            int x = 10;
            string s = "ÄãºÃÑ½";
            float f = 12.3f;
            events.threeParaEvent.Invoke(x, s, f);
        });
    }
}
