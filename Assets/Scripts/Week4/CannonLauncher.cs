using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLauncher : MonoBehaviour
{
    //All modifiable variables
    public float launchVelocity = 10f;
    public float launchAngle = 30f;
    public float Gravity = -9.8f;

    public Vector3 v3InitialVelocity;
    public Vector3 v3CurrentVelocity;
    public Vector3 v3Acceleration;

    private float airTime = 0f;
    private float xDisplacement = 0f;

    private bool simulate = false;

    //Work out velocity as vector quantity
    private void CalculateProjectile() {
        v3InitialVelocity.x = launchVelocity * Mathf.Cos(launchAngle * Mathf.Deg2Rad);
        v3InitialVelocity.y = launchVelocity * Mathf.Sin(launchAngle * Mathf.Deg2Rad);

        //Gravity as a vector
        v3Acceleration = new Vector3(0f, Gravity, 0f);

        //Calculating total air time
        float finalYVel = 0f;
        airTime = 2f * (finalYVel - v3InitialVelocity.y) / v3Acceleration.y;

        //Calculate total distance travelled by x 
        xDisplacement = airTime * v3InitialVelocity.x;
    }
    private void FixedUpdate(){
        if (simulate){
            Vector3 currentPos = transform.position;
            //Work out current veloctiy
            v3CurrentVelocity += v3Acceleration * Time.fixedDeltaTime;
            //Work out displacement
            Vector3 displacement = v3CurrentVelocity * Time.fixedDeltaTime;
            currentPos += displacement;
            transform.position = currentPos;
        }
    }

    //Variables that relate to the drawing of the projectile path
    private List<Vector3> pathPoints;
    // number of points on the projectiles path
    private int simulationSteps = 30; 


    private void CalculatePath(){
        Vector3 launchPos = transform.position;
        pathPoints.Add(launchPos);

        for (int i = 0; i <= simulationSteps; i++){
            float simTime = (i / (float)simulationSteps) * airTime;
            //Suvats formula of displacement (s = ut + 1/2at^2)
            Vector3 displacement = v3InitialVelocity * simTime + v3Acceleration * simTime * simTime * 0.5f;
            Vector3 drawPoint = launchPos + displacement;
            pathPoints.Add (drawPoint);
        }
    }

    void DrawPath() { 
        for (int i = 0 ; i < pathPoints.Count-1 ; i++){
            Debug.DrawLine(pathPoints[i], pathPoints[i + 1], Color.green);
        }
    }


    // Start is called before the first frame update
    void Start(){
        pathPoints = new List<Vector3>();
        CalculateProjectile();
        CalculatePath();
    }

    // Update is called once per frame
    void Update(){
        DrawPath();
        if (Input.GetKeyDown(KeyCode.Space) && simulate == false){
            simulate = true;
            v3CurrentVelocity = v3InitialVelocity;
            }
        if (Input.GetKeyDown (KeyCode.R)) {
            simulate = false;
            transform.position = Vector3.zero;
            }
    }
}
