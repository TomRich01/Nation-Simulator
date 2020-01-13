using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantumEconomyManager : MonoBehaviour
{
    public List<Currency> currencies;

    public float Transaction(string currentCurrency, float amount, string newCurrency)
    {
        Debug.Log(currentCurrency);
        float a = currencies.Find(cur => (cur.ID + "$") == currentCurrency).value;
        float b = currencies.Find(cur => (cur.ID + "$") == newCurrency).value;
        return (amount * (a / b));
    }

    public string FindCurrencyID(string currency)
    {
        string[] vs = currency.Split('$');
        return currencies.Find(newCurrency => newCurrency.ID == vs[0]).ID;
    }

    [System.Serializable]
    public class Currency
    {
        public string name, ID;
        public float value;
    }
}
