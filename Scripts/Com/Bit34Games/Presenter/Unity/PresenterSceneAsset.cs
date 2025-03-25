using System;
using Com.Bit34Games.Presenter.Constants;
using Com.Bit34Games.Presenter.Utilities;
using UnityEngine;


namespace Com.Bit34Games.Presenter.Unity
{
    [Serializable]
    public class PresenterSceneAsset : IPresenterSceneAsset
    {
        //  MEMBERS
        public PresenterViews View   { get{ return _view; } }
        public string         Name   { get{ return _name; } }
        public GameObject     Prefab { get{ return _prefab; } }
        //      Fro Editor
        [SerializeField] private PresenterViews _view;
        [SerializeField] private string         _name;
        [SerializeField] private GameObject     _prefab;
    }
}
