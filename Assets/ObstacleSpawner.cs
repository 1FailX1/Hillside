using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    //This class handles the spawning of all objects during playtime.

    private Vector3 previousObstaclePosition = new Vector3(100, 0, 50);
    private Vector3 previousBGPillarPosition = new Vector3(0, 0, 0);
    public GameObject PlayerBall;
    public GameObject Background_Pillar;
    public GameObject Background_Pillar_Red;
    public GameObject[] objects;
    public Vector3[] distanceAfterObject;
    public Vector3[] distanceBeforeObject;

    private int previousObstacleIndex;
    private int[] lastTwoObjectIndexes = new int[2];
    int obstacleIndex;

    // Start is called before the first frame update.
    // The first obstacle is always the same and is destroyed after 10 seconds.
    void Start()
    {
        GameObject firstObstacle = Instantiate(objects[0]);
        firstObstacle.transform.position = new Vector3(0, -30, 0);
        previousObstaclePosition = firstObstacle.transform.position;
        previousObstacleIndex = 0;
        Destroy(firstObstacle, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(previousBGPillarPosition.x - PlayerBall.transform.position.x);
        if (previousObstaclePosition.x - PlayerBall.transform.position.x < 1200)
        {
            obstacleIndex = Random.Range(0, objects.Length + 1);
            
            while(obstacleIndex == lastTwoObjectIndexes[0] || obstacleIndex == lastTwoObjectIndexes[1])
                obstacleIndex = Random.Range(0, objects.Length + 1);

            GameObject currentObstacle;
            switch (obstacleIndex)
            {
                case 0: //Basic Object
                    for (int i = 0; i < 4; i++)
                    {
                        currentObstacle = Instantiate(objects[obstacleIndex]);
                        currentObstacle.transform.position = previousObstaclePosition + distanceBeforeObject[obstacleIndex] + distanceAfterObject[previousObstacleIndex] + new Vector3(0, 0, Random.Range(-5, 5));
                        previousObstaclePosition = currentObstacle.transform.position;
                        previousObstacleIndex = obstacleIndex;
                        Destroy(currentObstacle, 40);
                    }
                    break;
                case 1: //Long Two Red on Side one Big Red Middle
                    for (int i = 0; i < 4; i++)
                    {
                        currentObstacle = Instantiate(objects[obstacleIndex]);
                        currentObstacle.transform.position = previousObstaclePosition + distanceBeforeObject[obstacleIndex] + distanceAfterObject[previousObstacleIndex] + new Vector3(0, 0, Random.Range(-5, 5));
                        previousObstaclePosition = currentObstacle.transform.position;
                        previousObstacleIndex = obstacleIndex;
                        Destroy(currentObstacle, 30);

                        //Spawning Red Background Pillars

                        GameObject leftPillar = Instantiate(Background_Pillar_Red);
                        leftPillar.transform.position = previousObstaclePosition + distanceAfterObject[1] + new Vector3(25, -180, 40);
                        Destroy(leftPillar, 30);
                        GameObject rightPillar = Instantiate(Background_Pillar_Red);
                        rightPillar.transform.position = previousObstaclePosition + distanceAfterObject[1] + new Vector3(25, -180, -40);
                        Destroy(rightPillar, 30);
                    }
                    break;
                case 2: //Side Slope Left
                    for (int i = 0; i < 4; i++)
                    {
                        currentObstacle = Instantiate(objects[obstacleIndex]);
                        currentObstacle.transform.position = previousObstaclePosition + distanceBeforeObject[obstacleIndex] + distanceAfterObject[previousObstacleIndex] + new Vector3(0, 0, Random.Range(-5, 5));
                        if (Random.Range(0, 9) >= 5) {
                            currentObstacle.transform.localScale = new Vector3(1, 1, -1);
                        }
                        previousObstaclePosition = currentObstacle.transform.position;
                        previousObstacleIndex = obstacleIndex;
                        Destroy(currentObstacle, 30);
                    }
                    break;
                case 3: //Speed Up
                        currentObstacle = Instantiate(objects[obstacleIndex]);
                        currentObstacle.transform.position = previousObstaclePosition + distanceBeforeObject[obstacleIndex] + distanceAfterObject[previousObstacleIndex] + new Vector3(0, 0, Random.Range(-5, 5));
                        previousObstaclePosition = currentObstacle.transform.position;
                        previousObstacleIndex = obstacleIndex;
                        Destroy(currentObstacle, 30);
                    break;

            }
            lastTwoObjectIndexes[1] = lastTwoObjectIndexes[0];
            lastTwoObjectIndexes[0] = obstacleIndex;
        }

        //BACKGROUND OBSTACLES: DONE FOR NOW

        if ( PlayerBall.transform.position.x - previousBGPillarPosition.x > -1900) 
        {
            int depth_increase = 0;
            for  (int length_distance = 250; length_distance <= 1500; length_distance += 250)
            {
                for (int width_distance = 350; width_distance <= 1350; width_distance += 250)
                {
                    GameObject currentBGPillar_left = Instantiate(Background_Pillar);
                    currentBGPillar_left.transform.position =
                        new Vector3(PlayerBall.transform.position.x + 2000 + length_distance, PlayerBall.transform.position.y - 2500 - depth_increase + Random.Range(-150, 150), width_distance);
                    Destroy(currentBGPillar_left, 50);
                    previousBGPillarPosition = currentBGPillar_left.transform.position;

                    GameObject currentBGPillar_right = Instantiate(Background_Pillar);
                    currentBGPillar_right.transform.position =
                        new Vector3(PlayerBall.transform.position.x + 2000 + length_distance, PlayerBall.transform.position.y - 2500 - depth_increase + Random.Range(-150, 150), -width_distance);
                    Destroy(currentBGPillar_right, 50);
                    previousBGPillarPosition = currentBGPillar_right.transform.position;
                }
                depth_increase += 50;
            }
        }
        
        
    }

}
