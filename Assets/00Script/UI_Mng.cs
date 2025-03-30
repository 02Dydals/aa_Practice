using UnityEngine;
using TMPro;

public class UI_Mng : MonoBehaviour
{
    public TextMeshProUGUI count_T;
   

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count_T.text = string.Format("{0} / 5", Luncher.instance.count);
    }
}
