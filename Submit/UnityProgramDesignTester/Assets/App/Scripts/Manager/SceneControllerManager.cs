using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneControllerManager : AutoGenerateManagerBase<SceneControllerManager>
{
    protected static readonly string SceneControllerName = "Controller";

    protected BaseController sceneController = null;

    /// <summary>
    /// 現在のシーンのコントローラーを取得する
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T GetSceneController<T>() where T : BaseController
    {
        if (sceneController == null)
        {
            CacheSceneController();
        }
        if (sceneController is T castedSceneController)
        {
            return castedSceneController;
        }
        // 指定のシーンコントローラーにキャストできない場合はnullを返す
        return null;
    }

    /// <summary>
    /// 現在のシーンのコントローラーをキャストしないで取得する
    /// </summary>
    /// <returns></returns>
    public BaseController GetBaseSceneController()
    {
        return sceneController;
    }

    /// <summary>
    /// 現在のシーンコントローラーをキャッシュする
    /// </summary>
    public void CacheSceneController()
    {
        sceneController = FindSceneController();
    }

    /// <summary>
    /// シーンコントローラーをシーンヒエラルキーから取得する
    /// </summary>
    /// <returns></returns>
    protected BaseController FindSceneController()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string controllerName = GenerateSceneControllerName(currentScene);

        BaseController sceneController = null;
        foreach (GameObject rootGameObject in currentScene.GetRootGameObjects())
        {
            if (rootGameObject.name != controllerName) continue;

            sceneController = rootGameObject.GetComponent<BaseController>();
            break;
        }

        return sceneController;
    }

    /// <summary>
    /// シーンコントローラー用のオブジェクトの名前を生成する
    /// [Scene名] + ["Controller"]
    /// </summary>
    /// <param name="scene"></param>
    /// <returns></returns>
    public string GenerateSceneControllerName(Scene scene)
    {
        return scene.name + SceneControllerName;
    }
}
