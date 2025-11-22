using UnityEngine;

public class Selectwallnutt : MonoBehaviour
{
    public int plantIndex = 1; 
    public void wallnutt()
    {
        plant_Manager.selectedPlantIndex = plantIndex; //sets wallnut to the array in plant_manager to 0
        Debug.Log("Selected index: " + plant_Manager.selectedPlantIndex);
    }
}
