using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shop : MonoBehaviour
{

    BuildManager buildManager;
    public TowerBluePrint tower1;
    public TowerBluePrint tower2;
    public TowerBluePrint tower3;
    public TowerBluePrint tower4;
    public TowerBluePrint tower5;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTower1() 
    {
        buildManager.SelectTower(tower1);
    }
    public void SelectTower2()
    {
        buildManager.SelectTower(tower2);
    }
    public void SelectTower3()
    {
        buildManager.SelectTower(tower3);
    }
    public void SelectTower4()
    {
        buildManager.SelectTower(tower4);
    }
    public void SelectTower5()
    {
        buildManager.SelectTower(tower5);
    }
}
