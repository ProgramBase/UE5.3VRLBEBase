using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FVector
	{
		public double this[int Index]
		{
			get => (double)FVectorImplementation.FVector_GetSubscriptImplementation(GarbageCollectionHandle, Index);

			set => FVectorImplementation.FVector_SetSubscriptImplementation(GarbageCollectionHandle, Index, value);
		}

		public static FVector ZeroVector
		{
			get => FVectorImplementation.FVector_GetZeroVectorImplementation(nint.Zero);
		}

		public static FVector OneVector
		{
			get => FVectorImplementation.FVector_GetOneVectorImplementation(nint.Zero);
		}

		public static FVector UpVector
		{
			get => FVectorImplementation.FVector_GetUpVectorImplementation(nint.Zero);
		}

		public static FVector DownVector
		{
			get => FVectorImplementation.FVector_GetDownVectorImplementation(nint.Zero);
		}

		public static FVector ForwardVector
		{
			get => FVectorImplementation.FVector_GetForwardVectorImplementation(nint.Zero);
		}

		public static FVector BackwardVector
		{
			get => FVectorImplementation.FVector_GetBackwardVectorImplementation(nint.Zero);
		}

		public static FVector RightVector
		{
			get => FVectorImplementation.FVector_GetRightVectorImplementation(nint.Zero);
		}

		public static FVector LeftVector
		{
			get => FVectorImplementation.FVector_GetLeftVectorImplementation(nint.Zero);
		}

		public static FVector XAxisVector
		{
			get => FVectorImplementation.FVector_GetXAxisVectorImplementation(nint.Zero);
		}

		public static FVector YAxisVector
		{
			get => FVectorImplementation.FVector_GetYAxisVectorImplementation(nint.Zero);
		}

		public static FVector ZAxisVector
		{
			get => FVectorImplementation.FVector_GetZAxisVectorImplementation(nint.Zero);
		}

		public FVector(double InF)
		{
			if (GetType() == typeof(FVector))
			{
				FVectorImplementation.FVector_FVectorImplementation(this, InF);
			}
		}

		public FVector(double InX, double InY, double InZ)
		{
			if (GetType() == typeof(FVector))
			{
				FVectorImplementation.FVector_FVector1Implementation(this, InX, InY, InZ);
			}
		}

		public FVector(FVector2D V, double InZ)
		{
			if (GetType() == typeof(FVector))
			{
				FVectorImplementation.FVector_FVector2Implementation(this, V?.GarbageCollectionHandle ?? nint.Zero, InZ);
			}
		}

		public FVector(FVector4 V)
		{
			if (GetType() == typeof(FVector))
			{
				FVectorImplementation.FVector_FVector3Implementation(this, V?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector(FLinearColor InColor)
		{
			if (GetType() == typeof(FVector))
			{
				FVectorImplementation.FVector_FVector4Implementation(this, InColor?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FVector operator ^(FVector InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_BitXorImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator +(FVector InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator -(FVector InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator *(FVector InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator /(FVector InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator -(FVector InValue0)
		{
			return FVectorImplementation.FVector_UnaryMinus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static double operator |(FVector InValue0, FVector InValue1)
		{
			return (double)FVectorImplementation.FVector_BitOrImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector operator -(FVector InValue0, int InValue1)
		{
			return FVectorImplementation.FVector_Minus2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator -(FVector InValue0, float InValue1)
		{
			return FVectorImplementation.FVector_Minus3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator -(FVector InValue0, double InValue1)
		{
			return FVectorImplementation.FVector_Minus4Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator +(FVector InValue0, int InValue1)
		{
			return FVectorImplementation.FVector_Plus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator +(FVector InValue0, float InValue1)
		{
			return FVectorImplementation.FVector_Plus2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator +(FVector InValue0, double InValue1)
		{
			return FVectorImplementation.FVector_Plus3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator *(FVector InValue0, int InValue1)
		{
			return FVectorImplementation.FVector_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator *(FVector InValue0, float InValue1)
		{
			return FVectorImplementation.FVector_Multiplies2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator *(FVector InValue0, double InValue1)
		{
			return FVectorImplementation.FVector_Multiplies3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator *(int InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_Multiplies4Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator *(float InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_Multiplies5Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator *(double InValue0, FVector InValue1)
		{
			return FVectorImplementation.FVector_Multiplies6Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector operator /(FVector InValue0, int InValue1)
		{
			return FVectorImplementation.FVector_Divides1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator /(FVector InValue0, float InValue1)
		{
			return FVectorImplementation.FVector_Divides2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector operator /(FVector InValue0, double InValue1)
		{
			return FVectorImplementation.FVector_Divides3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector;
		}

		public static FVector Zero()
		{
			return FVectorImplementation.FVector_ZeroImplementation(nint.Zero) as FVector;
		}

		public static FVector One()
		{
			return FVectorImplementation.FVector_OneImplementation(nint.Zero) as FVector;
		}

		public static FVector UnitX()
		{
			return FVectorImplementation.FVector_UnitXImplementation(nint.Zero) as FVector;
		}

		public static FVector UnitY()
		{
			return FVectorImplementation.FVector_UnitYImplementation(nint.Zero) as FVector;
		}

		public static FVector UnitZ()
		{
			return FVectorImplementation.FVector_UnitZImplementation(nint.Zero) as FVector;
		}

		public FVector Cross(FVector V2)
		{
			return FVectorImplementation.FVector_CrossImplementation(GarbageCollectionHandle, V2?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector CrossProduct(FVector A, FVector B)
		{
			return FVectorImplementation.FVector_CrossProductImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public double Dot(FVector V)
		{
			return (double)FVectorImplementation.FVector_DotImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double Dot(FVector A, FVector B)
		{
			return (double)FVectorImplementation.FVector_Dot1Implementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool Equals(FVector V, double Tolerance = 0.0001)
		{
			return (bool)FVectorImplementation.FVector_EqualsImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool AllComponentsEqual(double Tolerance = 0.0001)
		{
			return (bool)FVectorImplementation.FVector_AllComponentsEqualImplementation(GarbageCollectionHandle, Tolerance);
		}

		public double Component(int Index)
		{
			return (double)FVectorImplementation.FVector_ComponentImplementation(GarbageCollectionHandle, Index);
		}

		public double GetComponentForAxis(EAxis Axis)
		{
			return (double)FVectorImplementation.FVector_GetComponentForAxisImplementation(GarbageCollectionHandle, Axis);
		}

		public void SetComponentForAxis(EAxis Axis, double Component)
		{
			FVectorImplementation.FVector_SetComponentForAxisImplementation(GarbageCollectionHandle, Axis, Component);
		}

		public void Set(double InX, double InY, double InZ)
		{
			FVectorImplementation.FVector_SetImplementation(GarbageCollectionHandle, InX, InY, InZ);
		}

		public double GetMax()
		{
			return (double)FVectorImplementation.FVector_GetMaxImplementation(GarbageCollectionHandle);
		}

		public double GetAbsMax()
		{
			return (double)FVectorImplementation.FVector_GetAbsMaxImplementation(GarbageCollectionHandle);
		}

		public double GetMin()
		{
			return (double)FVectorImplementation.FVector_GetMinImplementation(GarbageCollectionHandle);
		}

		public double GetAbsMin()
		{
			return (double)FVectorImplementation.FVector_GetAbsMinImplementation(GarbageCollectionHandle);
		}

		public FVector ComponentMin(FVector Other)
		{
			return FVectorImplementation.FVector_ComponentMinImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector ComponentMax(FVector Other)
		{
			return FVectorImplementation.FVector_ComponentMaxImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector GetAbs()
		{
			return FVectorImplementation.FVector_GetAbsImplementation(GarbageCollectionHandle) as FVector;
		}

		public double Size()
		{
			return (double)FVectorImplementation.FVector_SizeImplementation(GarbageCollectionHandle);
		}

		public double Length()
		{
			return (double)FVectorImplementation.FVector_LengthImplementation(GarbageCollectionHandle);
		}

		public double SizeSquared()
		{
			return (double)FVectorImplementation.FVector_SizeSquaredImplementation(GarbageCollectionHandle);
		}

		public double SquaredLength()
		{
			return (double)FVectorImplementation.FVector_SquaredLengthImplementation(GarbageCollectionHandle);
		}

		public double Size2D()
		{
			return (double)FVectorImplementation.FVector_Size2DImplementation(GarbageCollectionHandle);
		}

		public double SizeSquared2D()
		{
			return (double)FVectorImplementation.FVector_SizeSquared2DImplementation(GarbageCollectionHandle);
		}

		public bool IsNearlyZero(double Tolerance = 0.0001)
		{
			return (bool)FVectorImplementation.FVector_IsNearlyZeroImplementation(GarbageCollectionHandle, Tolerance);
		}

		public bool IsZero()
		{
			return (bool)FVectorImplementation.FVector_IsZeroImplementation(GarbageCollectionHandle);
		}

		public bool IsUnit(double LengthSquaredTolerance = 0.0001)
		{
			return (bool)FVectorImplementation.FVector_IsUnitImplementation(GarbageCollectionHandle, LengthSquaredTolerance);
		}

		public bool IsNormalized()
		{
			return (bool)FVectorImplementation.FVector_IsNormalizedImplementation(GarbageCollectionHandle);
		}

		public bool Normalize(double Tolerance = 0.00000001)
		{
			return (bool)FVectorImplementation.FVector_NormalizeImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FVector GetUnsafeNormal()
		{
			return FVectorImplementation.FVector_GetUnsafeNormalImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetSafeNormal(double Tolerance = 0.00000001, FVector ResultIfZero = null)
		{
			ResultIfZero ??= new FVector(0.0 ,0.0 ,0.0);

			return FVectorImplementation.FVector_GetSafeNormalImplementation(GarbageCollectionHandle, Tolerance, ResultIfZero?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector GetSafeNormal2D(double Tolerance = 0.00000001, FVector ResultIfZero = null)
		{
			ResultIfZero ??= new FVector(0.0 ,0.0 ,0.0);

			return FVectorImplementation.FVector_GetSafeNormal2DImplementation(GarbageCollectionHandle, Tolerance, ResultIfZero?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public void ToDirectionAndLength(FVector OutDir, ref double OutLength)
		{
			FVectorImplementation.FVector_ToDirectionAndLengthImplementation(GarbageCollectionHandle, out var __OutValue, OutDir?.GarbageCollectionHandle ?? nint.Zero, OutLength);

			OutLength = (double)__OutValue[0];
		}

		public void ToDirectionAndLength(FVector OutDir, ref float OutLength)
		{
			FVectorImplementation.FVector_ToDirectionAndLength1Implementation(GarbageCollectionHandle, out var __OutValue, OutDir?.GarbageCollectionHandle ?? nint.Zero, OutLength);

			OutLength = (float)__OutValue[0];
		}

		public FVector GetSignVector()
		{
			return FVectorImplementation.FVector_GetSignVectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector Projection()
		{
			return FVectorImplementation.FVector_ProjectionImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetUnsafeNormal2D()
		{
			return FVectorImplementation.FVector_GetUnsafeNormal2DImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GridSnap(double GridSz)
		{
			return FVectorImplementation.FVector_GridSnapImplementation(GarbageCollectionHandle, GridSz) as FVector;
		}

		public FVector BoundToCube(double Radius)
		{
			return FVectorImplementation.FVector_BoundToCubeImplementation(GarbageCollectionHandle, Radius) as FVector;
		}

		public FVector BoundToBox(FVector Min, FVector Max)
		{
			return FVectorImplementation.FVector_BoundToBoxImplementation(GarbageCollectionHandle, Min?.GarbageCollectionHandle ?? nint.Zero, Max?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector GetClampedToSize(double Min, double Max)
		{
			return FVectorImplementation.FVector_GetClampedToSizeImplementation(GarbageCollectionHandle, Min, Max) as FVector;
		}

		public FVector GetClampedToSize2D(double Min, double Max)
		{
			return FVectorImplementation.FVector_GetClampedToSize2DImplementation(GarbageCollectionHandle, Min, Max) as FVector;
		}

		public FVector GetClampedToMaxSize(double MaxSize)
		{
			return FVectorImplementation.FVector_GetClampedToMaxSizeImplementation(GarbageCollectionHandle, MaxSize) as FVector;
		}

		public FVector GetClampedToMaxSize2D(double MaxSize)
		{
			return FVectorImplementation.FVector_GetClampedToMaxSize2DImplementation(GarbageCollectionHandle, MaxSize) as FVector;
		}

		public void AddBounded(FVector V, double Radius = 32767.0)
		{
			FVectorImplementation.FVector_AddBoundedImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero, Radius);
		}

		public FVector Reciprocal()
		{
			return FVectorImplementation.FVector_ReciprocalImplementation(GarbageCollectionHandle) as FVector;
		}

		public bool IsUniform(double Tolerance = 0.0001)
		{
			return (bool)FVectorImplementation.FVector_IsUniformImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FVector MirrorByVector(FVector MirrorNormal)
		{
			return FVectorImplementation.FVector_MirrorByVectorImplementation(GarbageCollectionHandle, MirrorNormal?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector MirrorByPlane(FPlane Plane)
		{
			return FVectorImplementation.FVector_MirrorByPlaneImplementation(GarbageCollectionHandle, Plane?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector RotateAngleAxis(double AngleDeg, FVector Axis)
		{
			return FVectorImplementation.FVector_RotateAngleAxisImplementation(GarbageCollectionHandle, AngleDeg, Axis?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public double CosineAngle2D(FVector B)
		{
			return (double)FVectorImplementation.FVector_CosineAngle2DImplementation(GarbageCollectionHandle, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector ProjectOnTo(FVector A)
		{
			return FVectorImplementation.FVector_ProjectOnToImplementation(GarbageCollectionHandle, A?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector ProjectOnToNormal(FVector Normal)
		{
			return FVectorImplementation.FVector_ProjectOnToNormalImplementation(GarbageCollectionHandle, Normal?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FRotator ToOrientationRotator()
		{
			return FVectorImplementation.FVector_ToOrientationRotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FQuat ToOrientationQuat()
		{
			return FVectorImplementation.FVector_ToOrientationQuatImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FRotator Rotation()
		{
			return FVectorImplementation.FVector_RotationImplementation(GarbageCollectionHandle) as FRotator;
		}

		public void FindBestAxisVectors(FVector Axis1, FVector Axis2)
		{
			FVectorImplementation.FVector_FindBestAxisVectorsImplementation(GarbageCollectionHandle, Axis1?.GarbageCollectionHandle ?? nint.Zero, Axis2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void UnwindEuler()
		{
			FVectorImplementation.FVector_UnwindEulerImplementation(GarbageCollectionHandle);
		}

		public bool ContainsNaN()
		{
			return (bool)FVectorImplementation.FVector_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FVectorImplementation.FVector_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public FText ToText()
		{
			return FVectorImplementation.FVector_ToTextImplementation(GarbageCollectionHandle) as FText;
		}

		public FString ToCompactString()
		{
			return FVectorImplementation.FVector_ToCompactStringImplementation(GarbageCollectionHandle) as FString;
		}

		public FText ToCompactText()
		{
			return FVectorImplementation.FVector_ToCompactTextImplementation(GarbageCollectionHandle) as FText;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FVectorImplementation.FVector_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool InitFromCompactString(FString InSourceString)
		{
			return (bool)FVectorImplementation.FVector_InitFromCompactStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector2D UnitCartesianToSpherical()
		{
			return FVectorImplementation.FVector_UnitCartesianToSphericalImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public double HeadingAngle()
		{
			return (double)FVectorImplementation.FVector_HeadingAngleImplementation(GarbageCollectionHandle);
		}

		public static void CreateOrthonormalBasis(FVector XAxis, FVector YAxis, FVector ZAxis)
		{
			FVectorImplementation.FVector_CreateOrthonormalBasisImplementation(nint.Zero, XAxis?.GarbageCollectionHandle ?? nint.Zero, YAxis?.GarbageCollectionHandle ?? nint.Zero, ZAxis?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool PointsAreSame(FVector P, FVector Q)
		{
			return (bool)FVectorImplementation.FVector_PointsAreSameImplementation(nint.Zero, P?.GarbageCollectionHandle ?? nint.Zero, Q?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool PointsAreNear(FVector Point1, FVector Point2, double Dist)
		{
			return (bool)FVectorImplementation.FVector_PointsAreNearImplementation(nint.Zero, Point1?.GarbageCollectionHandle ?? nint.Zero, Point2?.GarbageCollectionHandle ?? nint.Zero, Dist);
		}

		public static double PointPlaneDist(FVector Point, FVector PlaneBase, FVector PlaneNormal)
		{
			return (double)FVectorImplementation.FVector_PointPlaneDistImplementation(nint.Zero, Point?.GarbageCollectionHandle ?? nint.Zero, PlaneBase?.GarbageCollectionHandle ?? nint.Zero, PlaneNormal?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector PointPlaneProject(FVector Point, FPlane Plane)
		{
			return FVectorImplementation.FVector_PointPlaneProjectImplementation(nint.Zero, Point?.GarbageCollectionHandle ?? nint.Zero, Plane?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector PointPlaneProject(FVector Point, FVector A, FVector B, FVector C)
		{
			return FVectorImplementation.FVector_PointPlaneProject1Implementation(nint.Zero, Point?.GarbageCollectionHandle ?? nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, C?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector PointPlaneProject(FVector Point, FVector PlaneBase, FVector PlaneNormal)
		{
			return FVectorImplementation.FVector_PointPlaneProject2Implementation(nint.Zero, Point?.GarbageCollectionHandle ?? nint.Zero, PlaneBase?.GarbageCollectionHandle ?? nint.Zero, PlaneNormal?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector VectorPlaneProject(FVector V, FVector PlaneNormal)
		{
			return FVectorImplementation.FVector_VectorPlaneProjectImplementation(nint.Zero, V?.GarbageCollectionHandle ?? nint.Zero, PlaneNormal?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static double Dist(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double Distance(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistanceImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double DistXY(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistXYImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double Dist2D(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_Dist2DImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double DistSquared(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistSquaredImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double DistSquaredXY(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistSquaredXYImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double DistSquared2D(FVector V1, FVector V2)
		{
			return (double)FVectorImplementation.FVector_DistSquared2DImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double BoxPushOut(FVector Normal, FVector Size)
		{
			return (double)FVectorImplementation.FVector_BoxPushOutImplementation(nint.Zero, Normal?.GarbageCollectionHandle ?? nint.Zero, Size?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector Min(FVector A, FVector B)
		{
			return FVectorImplementation.FVector_MinImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector Max(FVector A, FVector B)
		{
			return FVectorImplementation.FVector_MaxImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector Min3(FVector A, FVector B, FVector C)
		{
			return FVectorImplementation.FVector_Min3Implementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, C?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector Max3(FVector A, FVector B, FVector C)
		{
			return FVectorImplementation.FVector_Max3Implementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, C?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static bool Parallel(FVector Normal1, FVector Normal2, double ParallelCosineThreshold = 0.999845028)
		{
			return (bool)FVectorImplementation.FVector_ParallelImplementation(nint.Zero, Normal1?.GarbageCollectionHandle ?? nint.Zero, Normal2?.GarbageCollectionHandle ?? nint.Zero, ParallelCosineThreshold);
		}

		public static bool Coincident(FVector Normal1, FVector Normal2, double ParallelCosineThreshold = 0.999845028)
		{
			return (bool)FVectorImplementation.FVector_CoincidentImplementation(nint.Zero, Normal1?.GarbageCollectionHandle ?? nint.Zero, Normal2?.GarbageCollectionHandle ?? nint.Zero, ParallelCosineThreshold);
		}

		public static bool Orthogonal(FVector Normal1, FVector Normal2, double OrthogonalCosineThreshold = 0.017455)
		{
			return (bool)FVectorImplementation.FVector_OrthogonalImplementation(nint.Zero, Normal1?.GarbageCollectionHandle ?? nint.Zero, Normal2?.GarbageCollectionHandle ?? nint.Zero, OrthogonalCosineThreshold);
		}

		public static bool Coplanar(FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, double ParallelCosineThreshold = 0.999845028)
		{
			return (bool)FVectorImplementation.FVector_CoplanarImplementation(nint.Zero, Base1?.GarbageCollectionHandle ?? nint.Zero, Normal1?.GarbageCollectionHandle ?? nint.Zero, Base2?.GarbageCollectionHandle ?? nint.Zero, Normal2?.GarbageCollectionHandle ?? nint.Zero, ParallelCosineThreshold);
		}

		public static double Triple(FVector X, FVector Y, FVector Z)
		{
			return (double)FVectorImplementation.FVector_TripleImplementation(nint.Zero, X?.GarbageCollectionHandle ?? nint.Zero, Y?.GarbageCollectionHandle ?? nint.Zero, Z?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double EvaluateBezier(FVector ControlPoints, int NumPoints, ref TArray<FVector> OutPoints)
		{
			var __ReturnValue = FVectorImplementation.FVector_EvaluateBezierImplementation(nint.Zero, out var __OutValue, ControlPoints?.GarbageCollectionHandle ?? nint.Zero, NumPoints, OutPoints?.GarbageCollectionHandle ?? nint.Zero);

			OutPoints = __OutValue[0] as TArray<FVector>;

			return (double)__ReturnValue;
		}

		public static FVector RadiansToDegrees(FVector RadVector)
		{
			return FVectorImplementation.FVector_RadiansToDegreesImplementation(nint.Zero, RadVector?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector DegreesToRadians(FVector DegVector)
		{
			return FVectorImplementation.FVector_DegreesToRadiansImplementation(nint.Zero, DegVector?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static void GenerateClusterCenters(ref TArray<FVector> Clusters, TArray<FVector> Points, int NumIterations, int NumConnectionsToBeValid)
		{
			FVectorImplementation.FVector_GenerateClusterCentersImplementation(nint.Zero, out var __OutValue, Clusters?.GarbageCollectionHandle ?? nint.Zero, Points?.GarbageCollectionHandle ?? nint.Zero, NumIterations, NumConnectionsToBeValid);

			Clusters = __OutValue[0] as TArray<FVector>;
		}
	}
}