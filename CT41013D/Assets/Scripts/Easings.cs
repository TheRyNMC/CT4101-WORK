using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Easings 
{
    public const float c4 = (2f * Mathf.PI) / 3f;
    public static float Linear (float t) {
        return t;
    }

    public class Quadratic { 
        public static float In (float t) {
            return t * t;
        }
        public static float Out(float t){
            return t * (2f - t);
        }

        public static float InOut(float t){
            if ((t *= 2f) < 1f) return 0.5f * t * t;
            return -0.5f * ((t -= 1f ) * ( t - 2f ) - 1f);
        }

        public static float Bezier(float t, float c){
            return c * 2 * t * (1 - t) + t * t;
        }
    }

    public class Trigonometric {
        public static float SIn(float t) {
            return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
        }


        public static float SOut(float t) {
            return 1f - Mathf.Sin(t * Mathf.PI * 0.5f);
        }

        public static float SinInOut(float t) {
            if ((t *= 2f) < 1f) return 0.5f * (1f - Mathf.Cos(t * Mathf.PI * 0.5f));
            return -0.5f * Mathf.Sin(t * Mathf.PI * 0.5f);
        }


        public static float EaseInElastic(float t) {
            if (t == 0) {
                return 0;
            } 
            else if (t == 1) {
                return 1;
            } 
            else {
                return -Mathf.Pow(2, 10 * t - 10) * Mathf.Sin((t * 10f - 10.75f) * c4);
            }
        }

        public static float EaseOutElastic(float t) {
                if (t == 0) {
                return 0;
                }
                else if (t == 1) {
                return 1;
                }
                else {
                return Mathf.Pow(2, -10 * t) * Mathf.Sin((t * 10f - 0.75f) * c4) + 1;
                }
            }
    
    
    
    
    }

}

