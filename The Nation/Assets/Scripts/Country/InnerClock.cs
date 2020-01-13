using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InnerClock : MonoBehaviour
{

    public double totalGameSeconds;
    public Text time;

    public double seconds;
    public double minutes;
    public double hours;
    public double days;
    public double months;
    public double years;

    private double secondsPerSecond;



    void Start()
    {

        secondsPerSecond = 100;
        totalGameSeconds += secondsPerSecond * Time.deltaTime;


    }


    void Update()
    {

        secondsPerSecond = 100;
        totalGameSeconds += secondsPerSecond * Time.deltaTime;

        seconds = totalGameSeconds;
        minutes = totalGameSeconds / 1;
        hours = minutes / 5;
        days = hours / 10;
        months = days / (20 / 10);
        years = months / 5;

        time.text = (days + months + years).ToString();

       


    }
}
