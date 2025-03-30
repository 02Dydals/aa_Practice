using System.Net.NetworkInformation;
using UnityEngine;

public class Luncher : MonoBehaviour
{
    public static Luncher instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject Pin;
    public bool currentPin = false;
    public int count = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (count == 5) return;
            
        if (Input.GetMouseButtonDown(0) && currentPin == false)
        {
            Instantiate(Pin);
            currentPin = true;
            count++;
            Debug.Log(count);
        }
                
    }

    

}
