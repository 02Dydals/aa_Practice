using Unity.VisualScripting;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public GameObject pinLine;    

    [SerializeField]
    private float moveSpeed = 1;
    private bool isHit = false;

    

    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit == false)
        {
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }                            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Target"))
        {
            transform.SetParent(collision.gameObject.transform);
            pinLine.SetActive(true);
            Luncher.instance.currentPin = false;
            isHit = true;
        }

        if(collision.CompareTag("Pin"))
        {
            Debug.Log("Lose");
        }

    }
}
