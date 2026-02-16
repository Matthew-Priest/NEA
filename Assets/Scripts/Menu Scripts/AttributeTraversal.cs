using UnityEngine;

public class AttributeTraversal : MonoBehaviour
{
    
    public GameObject attributeTree;
    private void Awake()
    {
        attributeTree.SetActive(false);
    }
    public void openTree()
    {
        attributeTree.SetActive(true);
    }
    public void closeTree()
    {
        attributeTree.SetActive(false);
    }
}
