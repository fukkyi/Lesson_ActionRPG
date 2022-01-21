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
    /// ���O���瑶�݂���V�[�������ׂ�
    /// </summary>
    /// <param name="sceneName"></param>
    /// <returns></returns>
    private bool ExistSceneByName(string sceneName)
    {
        // �L���ȃV�[���ł���Α��݂���ƌ��Ȃ�
        return true;
        //return SceneManager.GetSceneByName(sceneName).IsValid();
    }
}
