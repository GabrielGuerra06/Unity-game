using UnityEngine;

public class objects : MonoBehaviour
{
    public GameObject[] myObjects;
 

    public float speed = 25f;
    Vector3 movePosition = new Vector3(84f, 103.91f, 1000f);
    public float maxTime = 250;
    public float minTime = 200;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;
   
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
 

    }  

    // Update is called once per frame
    void Update()
    {
       
        FixedUpdate();

       if (enemy.transform.position != movePosition)
        {

            enemy.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            
        }
 


    }
    void FixedUpdate()
    {
      

        time += Time.deltaTime;

        int randomIndex = Random.Range(0, myObjects.Length);
        //Check if its the right time to spawn the objectS

        if (time >= spawnTime)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(82, 93), 103, Random.Range(140, 135));
            enemy = Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            collition();
            SetRandomTime();
         
            time = 0;
        }

     


    }
        void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void collition()
    {
       enemy.AddComponent<Rigidbody>();
       enemy.AddComponent<SphereCollider>();
       enemy.GetComponent<SphereCollider>().isTrigger= true;
       enemy.GetComponent<Rigidbody>().useGravity= false;
    }

  



    //Sets the random time between minTime and maxTime

}
 