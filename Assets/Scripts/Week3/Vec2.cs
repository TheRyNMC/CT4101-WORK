using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vec2{
    public float x = 0f, y = 0f;

    //Constructor 
    public Vec2(){
        x = 0f;
        y = 0f;
    }
    // Constructor with arguments
    public Vec2(float a_X, float a_Y){
        x = a_X;
        y = a_Y;
    }

    //Function coverting Vec2 into Vector2 
    public Vector2 ToVector2(){
        return new Vector2(x, y);
    }

    //Function coverting Vec3 into Vector3
    public Vector3 ToVector3(){
        return new Vector3(x, y);
    }

    public static Vec2 operator +(Vec2 a, Vec2 b){
        return new Vec2(a.x + b.x, a.y + b.y);
    }
    public static Vec2 operator -(Vec2 a, Vec2 b){
        return new Vec2(a.x - b.x, a.y - b.y);
    }
    public static Vec2 operator *(Vec2 a, Vec2 b){
        return new Vec2(a.x * b.x, a.y * b.y);
    }

    public static Vec2 operator * (Vec2 a, float s) {
        return new Vec2(a.x * s, a.y * s);
    }

    public static Vec2 operator- (Vec2 a) {
        return new Vec2(-a.x, -a.y);
    }

    //Magnitude (length) of Vec2
    public float Length() { 
        return Mathf.Sqrt(x * x + y * y);
    }

    //Method for magnitude without square root
    public float magSQR() { 
        return x * x + y * y;
    }

    //Dot product methods
    public float DotProduct(Vec2 a_B) { 
        //A.B = a.x * b.x + a.y * b.y
        return x * a_B.x + y * a_B.y;
    }
    // OR
    public static float DotProd(Vec2 a, Vec2 b){
        return a.x * b.x + a.y * b.y;
    }


    //Perpendicular Vec2
    public Vec2 Perp() { 
        return new Vec2(y, -x);
    }

    //Normalise vector
    //nA = (x /lA, y/lA)
    public Vec2 normVec() {
        float mag = Length();
        return new Vec2 (x / mag, y / mag);
    }

    //Rotate around Z-axis



    //Combinbing vectors




}
