using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeCommand : DebugCommand
{
    public override string CommandName => "scene_change";

    public override DebugCommandArgument[] Arguments => new DebugCommandArgument[] { 
        new DebugCommandArgument("scene"),
        new DebugCommandArgument("transType", "FadeInOut")
    };

    public override bool Execute(DebugCommandArgument[] arguments)
    {
        string sceneName = GetArgumentValueByName(arguments, "scene");
        string transType = GetArgumentValueByName(arguments, "transType");

        if (!ExistSceneByName(sceneName))
        {
            DebugManager.Instance.Console.PutErrorLog($"[{sceneName}] Scene Not Found");
            return false;
        }

        TransitionType transitionType = (TransitionType)Enum.Parse(typeof(TransitionType), transType, true);

        SceneTransitionManager.Instance.TransitionByName(sceneName, transitionType);

        DebugManager.Instance.Console.PutNoticeLog($"Scene Trasition To [{sceneName}]");

        return true;
    }

    /// <summary>
    /// 名前から存在するシーンか調べる
    /// </summary>
    /// <param name="sceneName"></param>
    /// <returns></returns>
    private bool ExistSceneByName(string sceneName)
    {
        // 有効なシーンであれば存在すると見なす
        return true;
        //return SceneManager.GetSceneByName(sceneName).IsValid();
    }
}
