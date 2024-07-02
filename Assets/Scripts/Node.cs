using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;

    BuildingManager buildingManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        buildingManager = BuildingManager.instance;
        startColor = rend.material.color;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset; 
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildingManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        buildingManager.BuildTurretOn (this);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildingManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
