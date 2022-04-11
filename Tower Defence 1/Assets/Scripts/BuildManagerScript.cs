using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManagerScript : MonoBehaviour
{
    public static BuildManagerScript instance;
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;
    public GameObject buildEffect;


    private TurretBlueprint turretToBuild;

    public bool CanBuild { get => turretToBuild != null; }
    public bool HasMoney { get => PlayerStats.Money >= turretToBuild.cost; }


    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one BuildManager on scene!");
            return;
        }
        instance = this;
    }
    public void BuildTurretOn(NodeScript node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money to build that.");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret build! Money left: " + PlayerStats.Money);
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
    
}
