using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube2 : MonoBehaviour
{
    public int xp=100;
    public Text txt;
    public GameObject cam;
    public GameObject bcam;
    public float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);
        bcam.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * speed *Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up *5* speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.down *5* speed * Time.deltaTime);

        if (xp <= 0)
        {
            cam.SetActive(true);
            bcam.SetActive(false);
            this.gameObject.SetActive(false);
            txt.text = "Игра окончена";
        }
        else txt.text = xp.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        xp-=20;
    }

    private void OnCollisionStay(Collision collision)
    {
        xp--;
    }
}
