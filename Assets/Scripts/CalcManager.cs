using System.Collections;
using System.Collections.Generic;
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
        if(count < 10)
        {
            count++;

        } else
        {
            count = 0;
        }

        Count.text = count.ToString();
    }

    public void OnClickResest()
    {
        Count.text = "0";
    }
}
