using UnityEngine;
using UnityEngine.UI;

public class LocationService : MonoBehaviour
{
    Text instruction;

    // Use this for initialization
    void Start()
    {
       InvokeRepeating("onClickUpdate", 0.0f,0.3f);

    }

   public void onClickUpdate(){

    //    print("hai");

        Input.location.Start();

        float X = Input.location.lastData.latitude;
        float Y = Input.location.lastData.longitude;
        

        instruction = gameObject.GetComponent<Text>();
        
        if(X >= 51.917310 && X <= 51.917650 && Y >= 4.484922 && Y <= 4.484982){
            instruction.text = "Zone 1";
            print("Zone 1");
        }
        else
        {
            instruction.text = "Geen Zone";
                        print("Geen Zone");
        }
        
        // instruction.text = "Location : " + "latitude =" + " " + Input.location.lastData.latitude + " " + "longitude =" + " " + Input.location.lastData.longitude;
        // if (!Input.location.isEnabledByUser) { print("yes"); }
    }

    // Update is called once per frame
    // void Update()
    // {
    // //     Input.location.Start();
    // //     instruction = gameObject.GetComponent<Text>();
        
        
    // //     instruction.text = "Location : " + "latitude =" + " " + Input.location.lastData.latitude + " " + "longitude =" + " " + Input.location.lastData.longitude;
    // //     if (!Input.location.isEnabledByUser) { print("yes"); }
    // //    InvokeRepeating("Update", 0.0f,1.0f);

    //      //   yield break;

     
    //     //print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
      
    //     // Input.location.Stop();


    // }
        
    }