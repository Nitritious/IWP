using UnityEngine;

public class Shop : MonoBehaviour
{
 
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    BuildingManager buildingManager;

    void Awake()
    {
        buildingManager = GameObject.FindWithTag("BuildManager").GetComponent<BuildingManager>();
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Purchased");
        buildingManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Another Turret Purchases");
        buildingManager.SelectTurretToBuild(missileLauncher);
    }
}
