using Unity.VisualScripting;
using UnityEngine;

public class ObstacleFactoryLifetime : MonoBehaviour
{
    public Lifetime lifetime;
    public GameObject prototype;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var newObject = Instantiate(prototype);
        newObject.GetComponent<Transform>().position = new Vector3(11, 1);
        newObject.SetActive(true);
        newObject.GetComponent<ObstacleLifetime>().IsAlive = true;
    }
}
