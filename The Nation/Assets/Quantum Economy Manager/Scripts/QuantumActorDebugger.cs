using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuantumActorDebugger : MonoBehaviour
{
    public Text text;
    public KeyCode pay;
    public float toPay;
    public Transform c;

    QuantumActor actor;

    private void Start()
    {
        actor = GetComponent<QuantumActor>();
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = actor.carrying.ToString() + " " + actor.mainCurrencyID + "$";
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(pay))
        {
            RaycastHit hit;
            if (Physics.Raycast(c.position, c.forward, out hit, 2.5f))
                if (hit.collider.GetComponent<QuantumActor>() != null)
                {
                    actor.Send(hit.collider.GetComponent<QuantumActor>(), toPay, "hand");
                    hit.collider.GetComponent<QuantumActorDebugger>().UpdateText();
                    UpdateText();
                }
        }
    }
}
