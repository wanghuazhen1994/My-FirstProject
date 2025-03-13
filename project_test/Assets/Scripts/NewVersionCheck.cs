using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using xasset;
using System;

public class NewVersionCheck : MonoBehaviour
{
    //获取更新信息 使用Assets.GetUpdateInfoAsync 可以获取客户端的更新信息

    public Text _versionTxt;

    IEnumerator Start()
    {
        //初始化XAsset
        var _initializeAsync = Assets.InitializeAsync();
        yield return _initializeAsync;
        //获取更新信息
        var _getUpdateInfo = Assets.GetUpdateInfoAsync();
        yield return _getUpdateInfo;
        if (_getUpdateInfo.result == Request.Result.Success)
        {
            Debug.LogError("XAsset GetUpdateInfoAsync Success");
        }
        //查看服务器上的版本号
        var _updateVersion = System.Version.Parse(_getUpdateInfo.info.version);
        //当前本地的版本号
        var _playerVersion = System.Version.Parse(Assets.PlayerAssets.version);
        //Major 主要版本  Minor 次要版本 强更只需要检测这两个号是否不同 patch 一般不同的是资源 热更即可
        if (_updateVersion.Major > _playerVersion.Major || 
            (_updateVersion.Major == _playerVersion.Major && _updateVersion.Minor > _playerVersion.Minor))
        {
            // var _request = 
        }
    }
}
