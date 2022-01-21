using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugConsole : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField = null;
    [SerializeField]
    private DebugConsoleLogger consoleLogger = null;

    private DebugCommandExecuter commandExecuter = new DebugCommandExecuter();

    private void Awake()
    {
        Init();
        commandExecuter.Init();
    }

    /// <summary>
    /// èâä˙âªèàóùÇçsÇ§
    /// </summary>
    private void Init()
    {
        
    }

    public void OnEnableConsole()
    {
        consoleLogger.SetLogScrollPositionToLastLog();
        inputField.ActivateInputField();
    }

    public void OnDisableConsole()
    {
        inputField.text = string.Empty;
    }

    public void OnEnteredCommand(string inputText)
    {
        if (!DebugManager.Instance.IsEnabledConsole) return;

        if (inputText != string.Empty)
        {
            consoleLogger.PutLog(DebugLogStatus.Command, inputText);
            commandExecuter.ExecuteCommand(inputText);
            inputField.text = string.Empty;
        }

        inputField.ActivateInputField();
    }

    public void PutNoticeLog(string content)
    {
        PutLog(DebugLogStatus.Notice, content);
    }

    public void PutOKLog(string content)
    {
        PutLog(DebugLogStatus.OK, content);
    }

    public void PutCautionLog(string content)
    {
        PutLog(DebugLogStatus.Caution, content);
    }

    public void PutErrorLog(string content)
    {
        PutLog(DebugLogStatus.Error, content);
    }

    private void PutLog(DebugLogStatus status, string content)
    {
        consoleLogger.SetLogScrollPositionToLastLog();
        consoleLogger.PutLog(status, content);
    }
}
