using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildingManager in scene.");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
