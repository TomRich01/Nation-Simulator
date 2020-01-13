using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantumActor : MonoBehaviour
{
    public string actorID;
    public string mainCurrencyID;
    public float carrying, secured, illegal, balance, debt;
    public List<Wallet> wallet;

    public void Send(QuantumActor actor, float amount, string via)
    {
        actor.Receive(mainCurrencyID + "$", amount, via);
        switch (via)
        {
            case "hand":
                carrying -= amount;
                break;
            case "secured":
                secured -= amount;
                break;
            case "illegal":
                illegal -= amount;
                break;
        }
        balance -= amount;
    }

    public void Receive(string currency, float amount, string via)
    {
        switch (via)
        {
            case "hand":
                if (currency == mainCurrencyID)
                    carrying += amount;
                else
                    carrying += FindObjectOfType<QuantumEconomyManager>().Transaction(currency, amount, mainCurrencyID + "$");
                break;
            case "secured":
                if (currency == mainCurrencyID)
                    secured += amount;
                else
                    secured += FindObjectOfType<QuantumEconomyManager>().Transaction(currency, amount, mainCurrencyID + "$");
                break;
            case "illegal":
                if (currency == mainCurrencyID)
                    illegal+= amount;
                else
                    illegal += FindObjectOfType<QuantumEconomyManager>().Transaction(currency, amount, mainCurrencyID + "$");
                break;
        }
        balance += amount;
    }

    [System.Serializable]
    public class Wallet
    {
        public string mainCurrencyID;
        public float carrying, secured, illegal, balance, debt;
    }
}
