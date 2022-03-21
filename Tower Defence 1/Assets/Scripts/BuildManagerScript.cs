using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManagerScript : MonoBehaviour
{
    public static BuildManagerScript instance;
    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;

    private GameObject turretToBuild;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one BuildManager on scene!");
            return;
        }
        instance = this;
    }   
    
    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
