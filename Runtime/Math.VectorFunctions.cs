﻿using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Unity.Mathematics
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class mathx
    {
        // Vector Specific Functions ------------------------------------------------------

        ///Normalized
        public static float4 norm(this float4 f) => math.normalize(f);
        public static float3 norm(this float3 f) => math.normalize(f);
        public static float2 norm(this float2 f) => math.normalize(f);
        
        public static float4 norm(this Vector4 f) => math.normalize(f);
        public static float3 norm(this Vector3 f) => math.normalize(f);
        public static float2 norm(this Vector2 f) => math.normalize(f);
        
        public static double4 norm(this double4 f) => math.normalize(f);
        public static double3 norm(this double3 f) => math.normalize(f);
        public static double2 norm(this double2 f) => math.normalize(f);
        
        
        ///Normalized safely
        public static float4 normsafe(this float4 f) => math.normalizesafe(f);
        public static float3 normsafe(this float3 f) => math.normalizesafe(f);
        public static float2 normsafe(this float2 f) => math.normalizesafe(f);
        
        public static float4 normsafe(this Vector4 f) => math.normalizesafe(f);
        public static float3 normsafe(this Vector3 f) => math.normalizesafe(f);
        public static float2 normsafe(this Vector2 f) => math.normalizesafe(f);
        
        public static double4 normsafe(this double4 f) => math.normalizesafe(f);
        public static double3 normsafe(this double3 f) => math.normalizesafe(f);
        public static double2 normsafe(this double2 f) => math.normalizesafe(f);
        
        
        ///Distance with self
        public static float distance(this float2 f, float2 f2) => math.distance(f, f2);
        public static float distance(this float3 f, float3 f2) => math.distance(f, f2);
        public static float distance(this float4 f, float4 f2) => math.distance(f, f2);
        
        public static float distance(this Vector2 f, float2 f2) => math.distance(f, f2);
        public static float distance(this Vector3 f, float3 f2) => math.distance(f, f2);
        public static float distance(this Vector4 f, float4 f2) => math.distance(f, f2);
        
        public static double distance(this double2 f, double2 f2) => math.distance(f, f2);
        public static double distance(this double3 f, double3 f2) => math.distance(f, f2);
        public static double distance(this double4 f, double4 f2) => math.distance(f, f2);
        
        
        ///Distancequared with self
        public static float distancesq(this float2 f, float2 f2) => math.distancesq(f, f2);
        public static float distancesq(this float3 f, float3 f2) => math.distancesq(f, f2);
        public static float distancesq(this float4 f, float4 f2) => math.distancesq(f, f2);
        
        public static float distancesq(this Vector2 f, float2 f2) => math.distancesq(f, f2);
        public static float distancesq(this Vector3 f, float3 f2) => math.distancesq(f, f2);
        public static float distancesq(this Vector4 f, float4 f2) => math.distancesq(f, f2);
        
        public static double distancesq(this double2 f, double2 f2) => math.distancesq(f, f2);
        public static double distancesq(this double3 f, double3 f2) => math.distancesq(f, f2);
        public static double distancesq(this double4 f, double4 f2) => math.distancesq(f, f2);
        
        
        ///Cross With Self
        public static float3 cross(this float3 f, float3 f2) => math.cross(f, f2);
        public static float3 cross(this Vector3 f, float3 f2) => math.cross(f, f2);
        public static double3 cross(this double3 f, double3 f2) => math.cross(f, f2);
        
        /// orthonormalize
        public static void orthonormalize(ref float3 normal, ref float3 tangent)
        {
            normal = normal.norm();
            tangent -= tangent.projectsafe(normal);
        }


        ///length
        public static float length(this float4 f) => math.length(f);
        public static float length(this float3 f) => math.length(f);
        public static float length(this float2 f) => math.length(f);
        
        public static float length(this Vector4 f) => math.length(f);
        public static float length(this Vector3 f) => math.length(f);
        public static float length(this Vector2 f) => math.length(f);
        
        public static double4 length(this double4 f) => math.length(f);
        public static double3 length(this double3 f) => math.length(f);
        public static double2 length(this double2 f) => math.length(f);


        ///Length Squared
        public static float lengthsq(this float4 f) => math.lengthsq(f);
        public static float lengthsq(this float3 f) => math.lengthsq(f);
        public static float lengthsq(this float2 f) => math.lengthsq(f);
        
        public static float lengthsq(this Vector4 f) => math.lengthsq(f);
        public static float lengthsq(this Vector3 f) => math.lengthsq(f);
        public static float lengthsq(this Vector2 f) => math.lengthsq(f);
        
        public static double lengthsq(this double4 f) => math.lengthsq(f);
        public static double lengthsq(this double3 f) => math.lengthsq(f);
        public static double lengthsq(this double2 f) => math.lengthsq(f);

        ///Square Root
        public static float4 sqrt(this float4 f) => math.sqrt(f);
        public static float3 sqrt(this float3 f) => math.sqrt(f);
        public static float2 sqrt(this float2 f) => math.sqrt(f);
        public static float sqrt(this float f) => math.sqrt(f);
        public static float sqrt(this int f) => math.sqrt(f);
        
        public static float4 sqrt(this Vector4 f) => math.sqrt(f);
        public static float3 sqrt(this Vector3 f) => math.sqrt(f);
        public static float2 sqrt(this Vector2 f) => math.sqrt(f);
        
        public static double4 sqrt(this double4 f) => math.sqrt(f);
        public static double3 sqrt(this double3 f) => math.sqrt(f);
        public static double2 sqrt(this double2 f) => math.sqrt(f);
        public static double sqrt(this double f) => math.sqrt(f);
        
        
        ///Cube Root
        
        private const double dthird = 0.333333333333333333333;
        private const float fthird = 0.3333333333f;
            
        public static float4 cbrt(this float4 f) => f.sign() * f.abs().pow(fthird);
        public static float3 cbrt(this float3 f) => f.sign() * f.abs().pow(fthird);
        public static float2 cbrt(this float2 f) => f.sign() * f.abs().pow(fthird);
        public static float cbrt(this float f) => f.sign() * f.abs().pow(fthird);
        public static float cbrt(this int f) => f.sign() * f.abs().pow(fthird);
        
        public static float4 cbrt(this Vector4 f) => f.sign() * f.abs().pow(fthird);
        public static float3 cbrt(this Vector3 f) => f.sign() * f.abs().pow(fthird);
        public static float2 cbrt(this Vector2 f) => f.sign() * f.abs().pow(fthird);

        public static double4 cbrt(this double4 f) => f.sign() * f.abs().pow(dthird);
        public static double3 cbrt(this double3 f) => f.sign() * f.abs().pow(dthird);
        public static double2 cbrt(this double2 f) => f.sign() * f.abs().pow(dthird);
        public static double cbrt(this double f) => f.sign() * f.abs().pow(dthird);
        
        
        ///Inverse cube root
        
        public static float4 rcbrt(this float4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this float3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this float2 f) => f.cbrt().rcp();
        public static float rcbrt(this float f) => f.cbrt().rcp();
        public static float rcbrt(this int f) => f.cbrt().rcp();
        
        public static float4 rcbrt(this Vector4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this Vector3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this Vector2 f) => f.cbrt().rcp();

        public static double4 rcbrt(this double4 f) => f.cbrt().rcp();
        public static double3 rcbrt(this double3 f) => f.cbrt().rcp();
        public static double2 rcbrt(this double2 f) => f.cbrt().rcp();
        public static double rcbrt(this double f) => f.cbrt().rcp();


        ///Inverse Square Root
        
        public static float4 rsqrt(this float4 f) => math.rsqrt(f);
        public static float3 rsqrt(this float3 f) => math.rsqrt(f);
        public static float2 rsqrt(this float2 f) => math.rsqrt(f);
        public static float rsqrt(this float f) => math.rsqrt(f);
        public static float rsqrt(this int f) => math.rsqrt(f);
        
        public static float4 rsqrt(this Vector4 f) => math.rsqrt(f);
        public static float3 rsqrt(this Vector3 f) => math.rsqrt(f);
        public static float2 rsqrt(this Vector2 f) => math.rsqrt(f);
        
        public static double4 rsqrt(this double4 f) => math.rsqrt(f);
        public static double3 rsqrt(this double3 f) => math.rsqrt(f);
        public static double2 rsqrt(this double2 f) => math.rsqrt(f);
        public static double rsqrt(this double f) => math.rsqrt(f);


        //m Operations From Matrices -------------------------------------------------


        ///Self Distance
        public static float distance(this float2x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float3x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float4x2 f) => math.distance(f.c0, f.c1);
        
        public static double distance(this double4x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double3x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double2x2 f) => math.distance(f.c0, f.c1);
        
        ///Self Squared Distance
        public static float distancesq(this float2x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float3x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float4x2 f) => math.distancesq(f.c0, f.c1);
        
        public static double distancesq(this double4x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double3x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double2x2 f) => math.distancesq(f.c0, f.c1);
        
        ///Self Cross
        public static float3 cross(this float3x2 f) => math.cross(f.c0, f.c1);
        public static double3 cross(this double3x2 f) => math.cross(f.c0, f.c1);
        
        ///Self Dot
        public static float dot(this float4x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float3x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float2x2 f) => math.dot(f.c0, f.c1);
        
        public static double dot(this double4x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double3x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double2x2 f) => math.dot(f.c0, f.c1);
        
        
        // Dot
        public static float dot(this float4 f, float4 f2) => math.dot(f, f2);
        public static float dot(this float3 f, float3 f2) => math.dot(f, f2);
        public static float dot(this float2 f, float2 f2) => math.dot(f, f2);
        
        
        public static double dot(this double4 f, double4 f2) => math.dot(f, f2);
        public static double dot(this double3 f, double3 f2) => math.dot(f, f2);
        public static double dot(this double2 f, double2 f2) => math.dot(f, f2);
        
        public static float dot(this Vector4 f, float4 f2) => math.dot(f, f2);
        public static float dot(this Vector3 f, float3 f2) => math.dot(f, f2);
        public static float dot(this Vector2 f, float2 f2) => math.dot(f, f2);
        
        
        // Reflect
        
        /// Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n
        public static float4 reflect(this float4 f, float4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float3 reflect(this float3 f, float3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float2 reflect(this float2 f, float2 n) => math.reflect(f, n);

        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float4 reflect(this Vector4 f, float4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float3 reflect(this Vector3 f, float3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float2 reflect(this Vector2 f, float2 n) => f.reflect(n);
        
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double4 reflect(this double4 f, double4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double3 reflect(this double3 f, double3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double2 reflect(this double2 f, double2 n) => math.reflect(f, n);
        
        
        ///Refract with self
        public static float2 refract(this float2 f, float2 f2, float eta) => math.refract(f, f2, eta);
        public static float3 refract(this float3 f, float3 f2, float eta) => math.refract(f, f2, eta);
        public static float4 refract(this float4 f, float4 f2, float eta) => math.refract(f, f2, eta);
        
        public static float2 refract(this Vector2 f, float2 f2, float eta) => math.refract(f, f2, eta);
        public static float3 refract(this Vector3 f, float3 f2, float eta) => math.refract(f, f2, eta);
        public static float4 refract(this Vector4 f, float4 f2, float eta) => math.refract(f, f2, eta);
        
        public static double2 refract(this double2 f, double2 f2, double eta) => math.refract(f, f2, eta);
        public static double3 refract(this double3 f, double3 f2, double eta) => math.refract(f, f2, eta);
        public static double4 refract(this double4 f, double4 f2, double eta) => math.refract(f, f2, eta);
        
            
        /// Compute vector projection of a onto b.
        public static float4 project(this float4 f, float4 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static float3 project(this float3 f, float3 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static float2 project(this float2 f, float2 n) => math.project(f, n);
    
        /// <inheritdoc cref="project(float4,float4)"/>
        public static float4 project(this Vector4 f, float4 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static float3 project(this Vector3 f, float3 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static float2 project(this Vector2 f, float2 n) => math.project(f, n);
        
        /// <inheritdoc cref="project(float4,float4)"/>
        public static double4 project(this double4 f, double4 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static double3 project(this double3 f, double3 n) => math.project(f, n);
        /// <inheritdoc cref="project(float4,float4)"/>
        public static double2 project(this double2 f, double2 n) => math.project(f, n);
    
    
    
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        public static float4 projectsafe(this float4 f, float4 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static float3 projectsafe(this float3 f, float3 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static float2 projectsafe(this float2 f, float2 n) => math.projectsafe(f, n);
    
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static float4 projectsafe(this Vector4 f, float4 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static float3 projectsafe(this Vector3 f, float3 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static float2 projectsafe(this Vector2 f, float2 n) => math.projectsafe(f, n);
        
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static double4 projectsafe(this double4 f, double4 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static double3 projectsafe(this double3 f, double3 n) => math.projectsafe(f, n);
        /// <inheritdoc cref="projectsafe(float4,float4)"/>
        public static double2 projectsafe(this double2 f, double2 n) => math.projectsafe(f, n);
    
    
    }
}