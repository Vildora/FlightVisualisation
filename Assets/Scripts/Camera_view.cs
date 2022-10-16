using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_view : MonoBehaviour
{

    private Camera mycam;
    public float viewspeed = 100f;
    float newview;
    float xScroll;
    float scrollspeed;

    // Start is called before the first frame update
    void Start()
    {
        mycam = GetComponent<Camera>();
        newview = mycam.fieldOfView;
        Screen.fullScreen = false;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(newview);
        
        Viewchanger();
    }
    void Viewchanger()
    {
        xScroll = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(xScroll);

        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            mycam.fieldOfView = Mathf.Clamp(mycam.fieldOfView, 40f, 100f);
            if(Input.GetAxis("Mouse ScrollWheel") > 0)
            {
               // Debug.Log("+");
                mycam.fieldOfView += viewspeed;
                

            }
            if(Input.GetAxis("Mouse ScrollWheel") < 0)
            {
//Debug.Log("-");
                mycam.fieldOfView -= viewspeed;
            }

        }
        


    }
}
