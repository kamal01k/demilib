﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/01/25 20:48
// License Copyright (c) Daniele Giardini

using UnityEngine;

namespace DG.DeUtils
{
    public static class DeVectorUtils
    {
        /// <summary>
        /// Returns the Y angle in degrees of the given vector, based on world coordinates.
        /// </summary>
        public static float AngleY(Vector3 v)
        {
            float angle = Vector3.Angle(Vector3.forward, v);
            if (v.x < 0) angle = 360 - angle;
            return angle;
        }
    }
}