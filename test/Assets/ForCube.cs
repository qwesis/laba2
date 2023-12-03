using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public Text t;
    bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hide_show()
    {
        this.gameObject.SetActive(a);
        if (a)
        {
            t.text = "куб виден";
            a = false;
        }
        else
        {
            t.text = "куб скрыт";
            a = true;
        }
    }
}
