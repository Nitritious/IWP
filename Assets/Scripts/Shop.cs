using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildingManager buildingManager;

    void Awake()
    {
        buildingManager = GameObject.FindWithTag("BuildManager").GetComponent<BuildingManager>();
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard Turret Purchased");
        buildingManager.SetTurretToBuild(buildingManager.standardTurretPrefab);
    }

    public void PurchaseMissileTurret()
    {
        Debug.Log("Another Turret Purchases");
        buildingManager.SetTurretToBuild(buildingManager.missileTurretPrefab);
    }
}
