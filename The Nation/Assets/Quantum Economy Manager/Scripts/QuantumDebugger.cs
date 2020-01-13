using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuantumDebugger : MonoBehaviour
{
    public QuantumEconomyManager economyManager;
    public Dropdown a, b;
    public InputField ai;
    public Text av, bv;

    public InputField cName, cID, cValue;

    private void Start()
    {
        economyManager = FindObjectOfType<QuantumEconomyManager>();
        UpdateDropdowns();
        UpdateText();
    }

    private void UpdateDropdowns()
    {
        a.ClearOptions();
        b.ClearOptions();
        foreach (var currency in economyManager.currencies)
        {
            a.options.Add(new Dropdown.OptionData(currency.ID + "$"));
            b.options.Add(new Dropdown.OptionData(currency.ID + "$"));
        }
        a.onValueChanged.AddListener(delegate { UpdateText(); });
        b.onValueChanged.AddListener(delegate { UpdateText(); });
    }

    public void CreateCurrency()
    {
        QuantumEconomyManager.Currency currency = new QuantumEconomyManager.Currency();
        currency.name = cName.text;
        currency.value = float.Parse(cValue.text);
        currency.ID = cID.text;
        economyManager.currencies.Add(currency);
        UpdateDropdowns();
        cName.text = "";
        cID.text = "";
        cValue.text = "";
    }

    public void UpdateText()
    {
        if (ai.text == "")
            return;
        av.text = ai.text + a.options[a.value].text;
        bv.text = economyManager.Transaction(a.options[a.value].text, float.Parse(ai.text), b.options[b.value].text).ToString("") + b.options[b.value].text;
    }
}
