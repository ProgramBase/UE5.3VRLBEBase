using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FQuat
	{
		public static FQuat Identity
		{
			get => FQuatImplementation.FQuat_GetIdentityImplementation(nint.Zero);
		}

		public FQuat(EForceInit InValue0)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuatImplementation(this, InValue0);
			}
		}

		public FQuat(double InX, double InY, double InZ, double InW)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuat1Implementation(this, InX, InY, InZ, InW);
			}
		}

		public FQuat(double V)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuat2Implementation(this, V);
			}
		}

		public FQuat(FRotator R)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuat3Implementation(this, R?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FQuat(FMatrix M)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuat4Implementation(this, M?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FQuat(FVector Axis, double AngleRad)
		{
			if (GetType() == typeof(FQuat))
			{
				FQuatImplementation.FQuat_FQuat5Implementation(this, Axis?.GarbageCollectionHandle ?? nint.Zero, AngleRad);
			}
		}

		public static FQuat operator +(FQuat InValue0, FQuat InValue1)
		{
			return FQuatImplementation.FQuat_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FQuat operator -(FQuat InValue0, FQuat InValue1)
		{
			return FQuatImplementation.FQuat_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FQuat operator -(FQuat InValue0)
		{
			return FQuatImplementation.FQuat_UnaryMinus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FQuat operator *(FQuat InValue0, FQuat InValue1)
		{
			return FQuatImplementation.FQuat_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FVector operator *(FQuat InValue0, FVector InValue1)
		{
			return FQuatImplementation.FQuat_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FQuat operator *(FQuat InValue0, float InValue1)
		{
			return FQuatImplementation.FQuat_Multiplies2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FQuat;
		}

		public static FQuat operator *(FQuat InValue0, double InValue1)
		{
			return FQuatImplementation.FQuat_Multiplies3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FQuat;
		}

		public static FQuat operator /(FQuat InValue0, float InValue1)
		{
			return FQuatImplementation.FQuat_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FQuat;
		}

		public static FQuat operator /(FQuat InValue0, double InValue1)
		{
			return FQuatImplementation.FQuat_Divides1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FQuat;
		}

		public static double operator |(FQuat InValue0, FQuat InValue1)
		{
			return (double)FQuatImplementation.FQuat_BitOrImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FQuat MakeFromRotator(FRotator InValue0)
		{
			return FQuatImplementation.FQuat_MakeFromRotatorImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public bool Equals(FQuat Q, double Tolerance = 0.0001)
		{
			return (bool)FQuatImplementation.FQuat_EqualsImplementation(GarbageCollectionHandle, Q?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool IsIdentity(double Tolerance = 0.00000001)
		{
			return (bool)FQuatImplementation.FQuat_IsIdentityImplementation(GarbageCollectionHandle, Tolerance);
		}

		public bool Identical(FQuat Q, uint PortFlags)
		{
			return (bool)FQuatImplementation.FQuat_IdenticalImplementation(GarbageCollectionHandle, Q?.GarbageCollectionHandle ?? nint.Zero, PortFlags);
		}

		public static FQuat MakeFromEuler(FVector Euler)
		{
			return FQuatImplementation.FQuat_MakeFromEulerImplementation(nint.Zero, Euler?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public FVector Euler()
		{
			return FQuatImplementation.FQuat_EulerImplementation(GarbageCollectionHandle) as FVector;
		}

		public void Normalize(double Tolerance = 0.00000001)
		{
			FQuatImplementation.FQuat_NormalizeImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FQuat GetNormalized(double Tolerance = 0.00000001)
		{
			return FQuatImplementation.FQuat_GetNormalizedImplementation(GarbageCollectionHandle, Tolerance) as FQuat;
		}

		public bool IsNormalized()
		{
			return (bool)FQuatImplementation.FQuat_IsNormalizedImplementation(GarbageCollectionHandle);
		}

		public double Size()
		{
			return (double)FQuatImplementation.FQuat_SizeImplementation(GarbageCollectionHandle);
		}

		public double SizeSquared()
		{
			return (double)FQuatImplementation.FQuat_SizeSquaredImplementation(GarbageCollectionHandle);
		}

		public double GetAngle()
		{
			return (double)FQuatImplementation.FQuat_GetAngleImplementation(GarbageCollectionHandle);
		}

		public void ToAxisAndAngle(FVector Axis, ref float Angle)
		{
			FQuatImplementation.FQuat_ToAxisAndAngleImplementation(GarbageCollectionHandle, out var __OutValue, Axis?.GarbageCollectionHandle ?? nint.Zero, Angle);

			Angle = (float)__OutValue[0];
		}

		public void ToAxisAndAngle(FVector Axis, ref double Angle)
		{
			FQuatImplementation.FQuat_ToAxisAndAngle1Implementation(GarbageCollectionHandle, out var __OutValue, Axis?.GarbageCollectionHandle ?? nint.Zero, Angle);

			Angle = (double)__OutValue[0];
		}

		public void ToSwingTwist(FVector InTwistAxis, FQuat OutSwing, FQuat OutTwist)
		{
			FQuatImplementation.FQuat_ToSwingTwistImplementation(GarbageCollectionHandle, InTwistAxis?.GarbageCollectionHandle ?? nint.Zero, OutSwing?.GarbageCollectionHandle ?? nint.Zero, OutTwist?.GarbageCollectionHandle ?? nint.Zero);
		}

		public double GetTwistAngle(FVector TwistAxis)
		{
			return (double)FQuatImplementation.FQuat_GetTwistAngleImplementation(GarbageCollectionHandle, TwistAxis?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector RotateVector(FVector V)
		{
			return FQuatImplementation.FQuat_RotateVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector UnrotateVector(FVector V)
		{
			return FQuatImplementation.FQuat_UnrotateVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FQuat Log()
		{
			return FQuatImplementation.FQuat_LogImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FQuat Exp()
		{
			return FQuatImplementation.FQuat_ExpImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FQuat Inverse()
		{
			return FQuatImplementation.FQuat_InverseImplementation(GarbageCollectionHandle) as FQuat;
		}

		public void EnforceShortestArcWith(FQuat OtherQuat)
		{
			FQuatImplementation.FQuat_EnforceShortestArcWithImplementation(GarbageCollectionHandle, OtherQuat?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector GetAxisX()
		{
			return FQuatImplementation.FQuat_GetAxisXImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetAxisY()
		{
			return FQuatImplementation.FQuat_GetAxisYImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetAxisZ()
		{
			return FQuatImplementation.FQuat_GetAxisZImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetForwardVector()
		{
			return FQuatImplementation.FQuat_GetForwardVectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetRightVector()
		{
			return FQuatImplementation.FQuat_GetRightVectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetUpVector()
		{
			return FQuatImplementation.FQuat_GetUpVectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector Vector()
		{
			return FQuatImplementation.FQuat_VectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FRotator Rotator()
		{
			return FQuatImplementation.FQuat_RotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FMatrix ToMatrix()
		{
			return FQuatImplementation.FQuat_ToMatrixImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public void ToMatrix(FMatrix Mat)
		{
			FQuatImplementation.FQuat_ToMatrix1Implementation(GarbageCollectionHandle, Mat?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector GetRotationAxis()
		{
			return FQuatImplementation.FQuat_GetRotationAxisImplementation(GarbageCollectionHandle) as FVector;
		}

		public double AngularDistance(FQuat Q)
		{
			return (double)FQuatImplementation.FQuat_AngularDistanceImplementation(GarbageCollectionHandle, Q?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ContainsNaN()
		{
			return (bool)FQuatImplementation.FQuat_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FQuatImplementation.FQuat_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FQuatImplementation.FQuat_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FQuat FindBetween(FVector Vector1, FVector Vector2)
		{
			return FQuatImplementation.FQuat_FindBetweenImplementation(nint.Zero, Vector1?.GarbageCollectionHandle ?? nint.Zero, Vector2?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FQuat FindBetweenNormals(FVector Normal1, FVector Normal2)
		{
			return FQuatImplementation.FQuat_FindBetweenNormalsImplementation(nint.Zero, Normal1?.GarbageCollectionHandle ?? nint.Zero, Normal2?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static FQuat FindBetweenVectors(FVector Vector1, FVector Vector2)
		{
			return FQuatImplementation.FQuat_FindBetweenVectorsImplementation(nint.Zero, Vector1?.GarbageCollectionHandle ?? nint.Zero, Vector2?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public static double Error(FQuat Q1, FQuat Q2)
		{
			return (double)FQuatImplementation.FQuat_ErrorImplementation(nint.Zero, Q1?.GarbageCollectionHandle ?? nint.Zero, Q2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double ErrorAutoNormalize(FQuat A, FQuat B)
		{
			return (double)FQuatImplementation.FQuat_ErrorAutoNormalizeImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FQuat FastLerp(FQuat A, FQuat B, double Alpha)
		{
			return FQuatImplementation.FQuat_FastLerpImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, Alpha) as FQuat;
		}

		public static FQuat FastBilerp(FQuat P00, FQuat P10, FQuat P01, FQuat P11, double FracX, double FracY)
		{
			return FQuatImplementation.FQuat_FastBilerpImplementation(nint.Zero, P00?.GarbageCollectionHandle ?? nint.Zero, P10?.GarbageCollectionHandle ?? nint.Zero, P01?.GarbageCollectionHandle ?? nint.Zero, P11?.GarbageCollectionHandle ?? nint.Zero, FracX, FracY) as FQuat;
		}

		public static FQuat Slerp_NotNormalized(FQuat Quat1, FQuat Quat2, double Slerp)
		{
			return FQuatImplementation.FQuat_Slerp_NotNormalizedImplementation(nint.Zero, Quat1?.GarbageCollectionHandle ?? nint.Zero, Quat2?.GarbageCollectionHandle ?? nint.Zero, Slerp) as FQuat;
		}

		public static FQuat Slerp(FQuat Quat1, FQuat Quat2, double Slerp)
		{
			return FQuatImplementation.FQuat_SlerpImplementation(nint.Zero, Quat1?.GarbageCollectionHandle ?? nint.Zero, Quat2?.GarbageCollectionHandle ?? nint.Zero, Slerp) as FQuat;
		}

		public static FQuat SlerpFullPath_NotNormalized(FQuat quat1, FQuat quat2, double Alpha)
		{
			return FQuatImplementation.FQuat_SlerpFullPath_NotNormalizedImplementation(nint.Zero, quat1?.GarbageCollectionHandle ?? nint.Zero, quat2?.GarbageCollectionHandle ?? nint.Zero, Alpha) as FQuat;
		}

		public static FQuat SlerpFullPath(FQuat quat1, FQuat quat2, double Alpha)
		{
			return FQuatImplementation.FQuat_SlerpFullPathImplementation(nint.Zero, quat1?.GarbageCollectionHandle ?? nint.Zero, quat2?.GarbageCollectionHandle ?? nint.Zero, Alpha) as FQuat;
		}

		public static FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, double Alpha)
		{
			return FQuatImplementation.FQuat_SquadImplementation(nint.Zero, quat1?.GarbageCollectionHandle ?? nint.Zero, tang1?.GarbageCollectionHandle ?? nint.Zero, quat2?.GarbageCollectionHandle ?? nint.Zero, tang2?.GarbageCollectionHandle ?? nint.Zero, Alpha) as FQuat;
		}

		public static FQuat SquadFullPath(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, double Alpha)
		{
			return FQuatImplementation.FQuat_SquadFullPathImplementation(nint.Zero, quat1?.GarbageCollectionHandle ?? nint.Zero, tang1?.GarbageCollectionHandle ?? nint.Zero, quat2?.GarbageCollectionHandle ?? nint.Zero, tang2?.GarbageCollectionHandle ?? nint.Zero, Alpha) as FQuat;
		}

		public static void CalcTangents(FQuat PrevP, FQuat P, FQuat NextP, double Tension, FQuat OutTan)
		{
			FQuatImplementation.FQuat_CalcTangentsImplementation(nint.Zero, PrevP?.GarbageCollectionHandle ?? nint.Zero, P?.GarbageCollectionHandle ?? nint.Zero, NextP?.GarbageCollectionHandle ?? nint.Zero, Tension, OutTan?.GarbageCollectionHandle ?? nint.Zero);
		}
	}
}