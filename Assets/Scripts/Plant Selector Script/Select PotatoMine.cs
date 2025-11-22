using UnityEngine;

public class SelectPotatoMine : MonoBehaviour
{
    public int plantIndex = 3; 
    public void potato()
    {
        plant_Manager.selectedPlantIndex = plantIndex; //sets potatomine to the array in plant_manager to 3
        Debug.Log("Selected index: " + plant_Manager.selectedPlantIndex);
    }
}
