using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float initSpd = 2.0f;
    public float spdInc = .01f;
    public float maxSpd = 10.0f;

    private float currSpd;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        currSpd = initSpd;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(initSpd, rb.velocity.y);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //moves the camera horizontally
        rb.velocity = new Vector2(initSpd, rb.velocity.y);

        //increase spd over time up to max
        /*currSpd += spdInc * Time.deltaTime;
         * currSpd = Mathf.Min(currSpd, maxSpd);
         */

    }
}
