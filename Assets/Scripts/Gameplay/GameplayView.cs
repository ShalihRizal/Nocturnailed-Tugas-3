using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

public class GameplayView : BaseSceneView
{
    [SerializeField] public SpaceView SpaceView;
    [SerializeField] public BulletPoolView BulletPoolView;
    [SerializeField] public PowerUpPoolView PowerUpPoolView;
    [SerializeField] public EnemyPoolView EnemyPoolView;
}
