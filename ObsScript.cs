using UnityEngine;

public class ObsScript : MonoBehaviour
{

    public ObsGen obsGen;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * obsGen.currentSped * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("next"))
        {
            obsGen.genObsTimeAlt();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Player")) && (gameObject.CompareTag("Ow")))
        {
            Destroy(this.gameObject);
        }
    }
}
