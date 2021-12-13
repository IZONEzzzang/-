using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject BuildEffect;

    private void Awake()
    {
        instance = this;
    }

    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;
    public GameObject tower5;

    private TowerBluePrint towerBuild;

    public bool CanBuild { get { return towerBuild != null; } }
    public bool CantBuild { get { return towerBuild == null; } }
    public bool HasMoney { get { return PlayerStats.Money >= towerBuild.cost; } }

    public void BuildTowersOn(Node node)
    {
        if(PlayerStats.Money < towerBuild.cost){
            return;
        }
        PlayerStats.Money -= towerBuild.cost;

        GameObject tower = Instantiate(towerBuild.towerPrefab, node.GetBuildPosition(), Quaternion.identity);
        node.tower = tower;
        Instantiate(BuildEffect, node.GetBuildPosition2(), Quaternion.identity);
        
    }
    public void SelectTower(TowerBluePrint tower)
    {
        towerBuild = tower;
    }
    public void DeselectTower()
    {
        towerBuild = null;
    }
}
