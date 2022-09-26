using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class LinePlotter : MonoBehaviour
{
    private List<Vector3> points;
    public float x1 = 0f;
    public float y1 = 0f;
    public float m = 1f;
    public float c = 0f;
    [Range(-5, 5)]
    public int p = 1;

    private float calculateY(float y1, float x, float x1, float m, float c)
    {
        return m * Mathf.Pow(x - x1, p) + c + y1;
    }

    // Start is called before the first frame update
    void Start()
    {
        points = new List<Vector3>();
        float x = -10f;
        for (float xPos = x; xPos < 10f; xPos += 0.2f)
        {
            points.Add(new Vector3(xPos, calculateY(y1, xPos, x1, m, c), 0f));
            xPos += 0.2f;
        }
    }

    private void OnValidate()
    {
        points.Clear();
        float x = -10f;
        for (float xPos = x; xPos < 10f; xPos += 0.2f)
        {
            points.Add(new Vector3(xPos, calculateY(y1, xPos, x1, m, c), 0f));
            xPos += 0.2f;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmos()
    {
        if (points != null)
        {
            Gizmos.color = Color.red;
            for (int i = 0; i < points.Count; i++)
            {
                Gizmos.DrawLine(points[i], points[i + 1]);
            }
        }
    }
}


