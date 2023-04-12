using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class titleScreenText : MonoBehaviour
{
    
    Text mText;
    RectTransform mTransform;
    // Start is called before the first frame update
    void Start()
    {
        mText = GetComponent<Text>();
        Debug.Log("Got the Component!");
        mTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        changeFontSize();
    }

    void changeFontSize(){
        bool flip = false;
        while (true) {
            if (flip){
                mText.fontSize -= 5;
                mTransform.sizeDelta = new Vector2(mText.fontSize,100);
                if (mText.fontSize < 60)
                    flip = false;
            }
            else {
                mText.fontSize += 1;
                mTransform.sizeDelta = new Vector2(mText.fontSize,100);
                if (mText.fontSize > 100)
                    flip = true;
            }

        }
    }

}
