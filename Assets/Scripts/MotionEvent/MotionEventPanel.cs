using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotionEventPanel : MonoBehaviour
{
    [SerializeField]
    private Button saveButton = null;
    [SerializeField]
    private Button resetButton = null;
    [SerializeField]
    private Button createNewMotionEventButton = null;
    [SerializeField]
    private GameObject motionListItemSrollView = null;
    [SerializeField]
    private Transform motionEventItemParent = null;
    [SerializeField]
    private MotionEventListItem listItemTemplate = null;

    private AnimationClip currentClip = null;

    public void Setup(AnimationClip clip)
    {
        currentClip = clip;

        if (currentClip != null)
        {
            AnimationEvent[] eventDatas = currentClip.events;
            if (eventDatas == null) return;
            if (eventDatas.Length == 0)
            {
                motionListItemSrollView.SetActive(false);
                return;
            }

            SetupMotionEventPanel(eventDatas);
        }
    }

    private void SetupMotionEventPanel(AnimationEvent[] events)
    {
        if (motionEventItemParent != null)
        {
            foreach (Transform child in motionEventItemParent)
            {
                if (child.GetComponent<MotionEventListItem>().IsClonedObject)
                {
                    Destroy(child.gameObject);
                }
            }
        }

        listItemTemplate.gameObject.SetActive(true);
        foreach(AnimationEvent eventData in events)
        {
            MotionEventListItem newListItem = Instantiate(listItemTemplate, motionEventItemParent);
            newListItem.IsClonedObject = true;
            newListItem.Setup(eventData);
        }

        listItemTemplate.gameObject.SetActive(false);
        motionListItemSrollView.SetActive(true);
    }
}
