using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    public TextMeshProUGUI upgradeCost;
    public Button upgradeButton;

    public TextMeshProUGUI SellAmount;

    private Node target;

    public void SetTarget (Node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        } else
        {
            upgradeCost.text = "DONE";
            upgradeButton.interactable = false;
        }

        SellAmount.text = "$" + target.turretBlueprint.GetSellAmount();


        ui.SetActive(true);
    }

    public void Hide ()
    { 
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildingManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildingManager.instance.DeselectNode();
    }
}
