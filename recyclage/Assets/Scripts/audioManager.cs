using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static audioManager instance;

    void Wake() {
        if (instance == null){
            instance = this;
                        
        }
    }
}
