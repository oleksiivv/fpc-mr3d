using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobvSlider : MonoBehaviour
{
    // Start is called before the first frame update
    float slVV = 0;
    public Slider slRotate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            slRotate.value = 0.5f;
        }
        else if (slRotate.value != 0.5f)
        {
            slVV += 0.5f - slRotate.value;
        }


        gameObject.transform.Rotate(0, slVV * 5, 0);
    }
}
