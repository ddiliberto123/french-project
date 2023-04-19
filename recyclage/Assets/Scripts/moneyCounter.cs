using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class moneyCounter : MonoBehaviour
{
    public static moneyCounter instance;

    public TMP_Text moneyText;
    public int currentMoney;

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Argent: " + currentMoney.ToString();
    }

    // Update is called once per frame

    public void increaseMoney(int v)
    {
        currentMoney += v;
        moneyText.text = "Argent: " + currentMoney.ToString();
    }
}
