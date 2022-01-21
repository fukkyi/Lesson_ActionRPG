using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSceneController : BaseController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("LoadTestScene")]
    public void LoadTestScene()
    {
        SceneTransitionManager.Instance.TransitionByName("TestScene");
    }
}
