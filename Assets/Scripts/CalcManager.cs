using UnityEngine;
using UnityEngine.UI;

public class CalcManager : MonoBehaviour
{
    public Text Count;
    public Button Good;
    public Button Reset;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Count.text = "0";
    }

    public void OnClickGood()
    {
        if (IsAbove(count))
        {
            count = 0;

        }
        else
        {
            count++;
        }

        Count.text = count.ToString();
    }

    public void OnClickResest()
    {
        Count.text = "0";
    }

    public bool IsAbove(int count)
    {
        return count > 10;
    }
}
