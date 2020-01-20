﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common
{
    static Vector3 m_vecResult;
    public static Vector3 RoataeToPos(Vector3 v_target, float v_angle)
    {
        float fAngle = v_angle * Mathf.Deg2Rad;
        float fNewX = v_target.x * Mathf.Cos(fAngle) - v_target.z * Mathf.Sin(fAngle);
        float fNewZ = v_target.x * Mathf.Sin(fAngle) + v_target.z * Mathf.Cos(fAngle);

        m_vecResult.x = fNewX;
        m_vecResult.y = v_target.y;
        m_vecResult.z = fNewZ;
        
        return m_vecResult; 
    }

    static Matrix4x4 matrix;
    static Vector4 v;
    public static Vector3 TranslateByMatrix(Vector3 v_basePos)
    {
        v = new Vector4(v_basePos.x, v_basePos.y, v_basePos.z, 1.0f);
        matrix = Matrix4x4.identity;

        v = matrix * v;
        return new Vector3(v.x, v.y, v.z);
    }

    public static Vector3 RoataeToPos2(Vector3 v_target, Vector3 v_ref, float v_angle)
    {
        float fAngle = v_angle * Mathf.Deg2Rad;
        float fNewX = (v_target.x - v_ref.x) * Mathf.Cos(fAngle) - (v_target.z - v_ref.z) * Mathf.Sin(fAngle);
        float fNewZ = (v_target.x - v_ref.x) * Mathf.Sin(fAngle) + (v_target.z - v_ref.z) * Mathf.Cos(fAngle);

        m_vecResult.x = fNewX;
        m_vecResult.y = v_target.y;
        m_vecResult.z = fNewZ;
        
        return m_vecResult; 
    }
}
