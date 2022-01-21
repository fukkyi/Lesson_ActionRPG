using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneController : BaseController
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("LoadSampleScene")]
    public void LoadSampleScene()
    {
        SceneTransitionManager.Instance.TransitionByName("SampleScene");
    }
}

