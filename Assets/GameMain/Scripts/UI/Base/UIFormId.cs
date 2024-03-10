//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace Duomee
{
    /// <summary>
    /// 界面编号。
    /// </summary>
    public enum UIFormId : byte
    {
        Undefined = 0,
        // 公共
        CommonDialog = 10,
        CommonToast = 11,
        // 登录
        DownloadForm = 100,
        LoginForm = 101,
        StartForm = 102,
        CharacterForm = 103,
    }
}
