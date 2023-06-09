using System;
using System.Collections.Generic;
using UnityEngine;

public enum UpdateType
{
    None = 0,
    //底包更新
    PackageUpdate = 1, 
    //资源更新
    ResourceUpdate = 2,
}

public enum UpdateStyle
{
    None = 0,
    Froce = 1,   //强制
    Optional = 2,//非强制
}

public enum UpdateNotice
{
    None = 0,
    Notice = 1,   //提示
    NoNotice = 2,//非提示
}
    
public enum GameStatus
{
    First = 0,
    AssetLoad = 1
}

/// <summary>
/// 资源存放地
/// </summary>
[Serializable]
public class ResourcesArea
{
    [Tooltip("资源管理类型")] [SerializeField] private string m_ResAdminType = "Default";

    public string ResAdminType
    {
        get { return m_ResAdminType; }
    }

    [Tooltip("资源管理编号")] [SerializeField] private string m_ResAdminCode = "0";

    public string ResAdminCode
    {
        get { return m_ResAdminCode; }
    }

    [SerializeField] private ServerTypeEnum m_ServerType = ServerTypeEnum.Intranet;

    public ServerTypeEnum ServerType
    {
        get { return m_ServerType; }
    }

    [Tooltip("是否在构建资源的时候清理上传到服务端目录的老资源")] [SerializeField]
    private bool m_CleanCommitPathRes = true;

    public bool CleanCommitPathRes
    {
        get { return m_CleanCommitPathRes; }
    }

    [Tooltip("内网地址")] [SerializeField] private string m_InnerResourceSourceUrl = "http://127.0.0.1:8088";

    public string InnerResourceSourceUrl
    {
        get { return m_InnerResourceSourceUrl; }
    }

    [Tooltip("外网地址")] [SerializeField] private string m_ExtraResourceSourceUrl = "http://127.0.0.1:8088";

    public string ExtraResourceSourceUrl
    {
        get { return m_ExtraResourceSourceUrl; }
    }

    [Tooltip("正式地址")] [SerializeField] private string m_FormalResourceSourceUrl = "http://127.0.0.1:8088";

    public string FormalResourceSourceUrl
    {
        get { return m_FormalResourceSourceUrl; }
    }
}

[Serializable]
public class ServerIpAndPort
{
    public string ServerName;
    public string Ip;
    public int Port;
}

[Serializable]
public class ServerChannelInfo
{
    public string ChannelName;
    public string CurUseServerName;
    public List<ServerIpAndPort> ServerIpAndPorts;
}

[Serializable]
public class FrameworkGlobalSettings
{
    [SerializeField] [Tooltip("脚本作者名")] private string m_ScriptAuthor = "Default";

    public string ScriptAuthor
    {
        get { return m_ScriptAuthor; }
    }

    [SerializeField] [Tooltip("版本")] private string m_ScriptVersion = "0.1";

    public string ScriptVersion
    {
        get { return m_ScriptVersion; }
    }

    [SerializeField] private AppStageEnum m_AppStage = AppStageEnum.Debug;

    public AppStageEnum AppStage
    {
        get { return m_AppStage; }
    }
    
    // // 资源更新类型
    // public UpdateType UpdateType = UpdateType.PackageUpdate;
    //     
    // // 更新是否强制
    // public UpdateStyle UpdateStyle = UpdateStyle.Froce;
    //     
    // // 更新提示类型
    // public UpdateNotice UpdateNotice = UpdateNotice.Notice;

    [Header("Font")] [SerializeField] private string m_DefaultFont = "Arial";
    public string DefaultFont => m_DefaultFont;

    [Header("Resources")] [Tooltip("资源存放地")] [SerializeField]
    private ResourcesArea m_ResourcesArea;

    public ResourcesArea ResourcesArea
    {
        get { return m_ResourcesArea; }
    }

    [Header("SpriteCollection")] [SerializeField]
    private string m_AtlasFolder = "Assets/AssetRaw/Atlas";

    public string AtlasFolder
    {
        get { return m_AtlasFolder; }
    }

    [Header("Hotfix")] [SerializeField] 
    private string m_ResourceVersionFileName = "ResourceVersion.txt";

    public string ResourceVersionFileName
    {
        get { return m_ResourceVersionFileName; }
    }

    public string CheckVersionUrl = "http://127.0.0.1/Resources/{0}Version.txt";
    public string WindowsAppUrl = "http://127.0.0.1";
    public string MacOSAppUrl = "http://127.0.0.1";
    public string IOSAppUrl = "http://127.0.0.1";
    public string AndroidAppUrl = "http://127.0.0.1";
    [Header("Server")] [SerializeField] private string m_CurUseServerChannel;

    public string CurUseServerChannel
    {
        get => m_CurUseServerChannel;
    }

    [SerializeField] private List<ServerChannelInfo> m_ServerChannelInfos;

    public List<ServerChannelInfo> ServerChannelInfos
    {
        get => m_ServerChannelInfos;
    }

    [Header("Config")] [Tooltip("是否读取本地表 UnityEditor 下起作用")] [SerializeField]
    private bool m_IsReadLocalConfigInEditor = true;

    public bool ReadLocalConfigInEditor
    {
        get { return m_IsReadLocalConfigInEditor; }
    }

    [SerializeField] private string m_ConfigFolderName = "Assets/AssetRaw/Configs/";

    public string ConfigFolderName
    {
        get { return m_ConfigFolderName; }
    }
}