using System;
using UnityEngine;

public class ClockTick : MonoBehaviour
{
    public GameObject HourHand;
    public GameObject MinuteHand;
    public GameObject SecondHand;

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        float hour = currentTime.Hour;
        if (hour > 12f)
            hour -= 12f;
        float minute = currentTime.Minute;
        float second = currentTime.Second;

        if (HourHand != null)
        {
            HourHand.transform.localEulerAngles = new Vector3(hour * 30f + minute * 0.2f, 0f, 0f);
        }
        if (MinuteHand != null)
        {
            MinuteHand.transform.localEulerAngles = new Vector3(minute * 6f, 0f, 0f);
        }
        if (SecondHand != null)
        {
            SecondHand.transform.localEulerAngles = new Vector3(second * 6f, 0f, 0f);
        }
    }
}
