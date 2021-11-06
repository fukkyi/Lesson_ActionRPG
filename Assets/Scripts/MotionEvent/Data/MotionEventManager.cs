using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionEventManager
{
    private static MotionEventManager instance = null;
    public static MotionEventManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MotionEventManager();
            }

            return instance;
        }
    }

    private MotionEventManager() { }

    public void Execute(string[] dataList)
    {
        if (dataList == null) { return; }

        foreach(string eventId in dataList)
        {
            if (!uint.TryParse(eventId, out uint targetEventId))
            {
                continue;
            }

            Debug.Log("Executed Event Id:" + targetEventId);
        }
    }
}
