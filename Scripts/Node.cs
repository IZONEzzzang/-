using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color NoMoneyrColor;
    public Vector3 positionOffset;
    public Vector3 positionOffset2;
    public GameObject tower;
    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    public Vector3 GetBuildPosition2()
    {
        return transform.position + positionOffset2;
    }

    private void OnMouseDown()
    {
        if (!buildManager.CanBuild) return;
        if(tower != null)
        {
            return;
        }
        buildManager.BuildTowersOn(this);
        buildManager.DeselectTower();
        
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;

        if (!buildManager.CanBuild) return;

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = NoMoneyrColor;
        }
        
        
    }

    private void OnMouseExit()
    {
        {
            rend.material.color = startColor;
        }
    }
}
