using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    BuildManagerScript buildManager;

    private void Start()
    {
        buildManager = BuildManagerScript.instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }
}
