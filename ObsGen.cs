using UnityEngine;

public class ObsGen : MonoBehaviour
{

    public GameObject groundObstacle;

    public float sped;
    public float currentSped;

    // Start is called before the first frame update
    void Awake()
    {
        currentSped = sped;
        generateGobs();
    }
    
    public void genObsTimeAlt()
    {
        float randomWait = Random.Range(0.05f, 1.5f);
        Invoke("generateGobs", randomWait);
    }

    public void generateGobs()
    {
        GameObject ObstacleGIns = Instantiate(groundObstacle, transform.position, transform.rotation);

        ObstacleGIns.GetComponent<ObsScript>().obsGen = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
