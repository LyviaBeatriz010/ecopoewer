using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialFill : MonoBehaviour
{
    Image img;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out img);
    }

    // Update is called once per frame
    void Update()
    {
        if(img.fillAmount <=1)
        {
            img.fillAmount +=  Time.deltaTime * speed;
        }
        
    }
}
