using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        var power = (transform.forward + transform.right) * speed;
        GetComponent<Rigidbody>().AddForce(power, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 30 || transform.position.x < -30)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
