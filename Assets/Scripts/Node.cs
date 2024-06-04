using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;

    BuildingManager buildingManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        buildingManager = BuildingManager.instance;
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (buildingManager.GetTurretToBuild() == null)
            return;
        if (turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        //Build a turret
        GameObject turretToBuild = buildingManager.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        if (buildingManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
