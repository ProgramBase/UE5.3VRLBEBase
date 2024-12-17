using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FMatrix
	{
		public static FMatrix Identity
		{
			get => FMatrixImplementation.FMatrix_GetIdentityImplementation(nint.Zero);
		}

		public FMatrix(EForceInit InValue0)
		{
			if (GetType() == typeof(FMatrix))
			{
				FMatrixImplementation.FMatrix_FMatrixImplementation(this, InValue0);
			}
		}

		public FMatrix(FPlane InX, FPlane InY, FPlane InZ, FPlane InW)
		{
			if (GetType() == typeof(FMatrix))
			{
				FMatrixImplementation.FMatrix_FMatrix1Implementation(this, InX?.GarbageCollectionHandle ?? nint.Zero, InY?.GarbageCollectionHandle ?? nint.Zero, InZ?.GarbageCollectionHandle ?? nint.Zero, InW?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FMatrix(FVector InX, FVector InY, FVector InZ, FVector InW)
		{
			if (GetType() == typeof(FMatrix))
			{
				FMatrixImplementation.FMatrix_FMatrix2Implementation(this, InX?.GarbageCollectionHandle ?? nint.Zero, InY?.GarbageCollectionHandle ?? nint.Zero, InZ?.GarbageCollectionHandle ?? nint.Zero, InW?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FMatrix operator *(FMatrix InValue0, FMatrix InValue1)
		{
			return FMatrixImplementation.FMatrix_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FMatrix;
		}

		public static FMatrix operator +(FMatrix InValue0, FMatrix InValue1)
		{
			return FMatrixImplementation.FMatrix_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FMatrix;
		}

		public static FMatrix operator *(FMatrix InValue0, double InValue1)
		{
			return FMatrixImplementation.FMatrix_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FMatrix;
		}

		public void SetIdentity()
		{
			FMatrixImplementation.FMatrix_SetIdentity1Implementation(GarbageCollectionHandle);
		}

		public bool Equals(FMatrix Other, double Tolerance = 0.0001)
		{
			return (bool)FMatrixImplementation.FMatrix_EqualsImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public FVector4 TransformFVector4(FVector4 P)
		{
			return FMatrixImplementation.FMatrix_TransformFVector4Implementation(GarbageCollectionHandle, P?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public FVector4 TransformPosition(FVector V)
		{
			return FMatrixImplementation.FMatrix_TransformPositionImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public FVector InverseTransformPosition(FVector V)
		{
			return FMatrixImplementation.FMatrix_InverseTransformPositionImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector4 TransformVector(FVector V)
		{
			return FMatrixImplementation.FMatrix_TransformVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public FVector InverseTransformVector(FVector V)
		{
			return FMatrixImplementation.FMatrix_InverseTransformVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FMatrix GetTransposed()
		{
			return FMatrixImplementation.FMatrix_GetTransposedImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public double Determinant()
		{
			return (double)FMatrixImplementation.FMatrix_DeterminantImplementation(GarbageCollectionHandle);
		}

		public double RotDeterminant()
		{
			return (double)FMatrixImplementation.FMatrix_RotDeterminantImplementation(GarbageCollectionHandle);
		}

		public FMatrix InverseFast()
		{
			return FMatrixImplementation.FMatrix_InverseFastImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public FMatrix Inverse()
		{
			return FMatrixImplementation.FMatrix_InverseImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public FMatrix TransposeAdjoint()
		{
			return FMatrixImplementation.FMatrix_TransposeAdjointImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public void RemoveScaling(double Tolerance = 0.00000001)
		{
			FMatrixImplementation.FMatrix_RemoveScalingImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FMatrix GetMatrixWithoutScale(double Tolerance = 0.00000001)
		{
			return FMatrixImplementation.FMatrix_GetMatrixWithoutScaleImplementation(GarbageCollectionHandle, Tolerance) as FMatrix;
		}

		public FVector ExtractScaling(double Tolerance = 0.00000001)
		{
			return FMatrixImplementation.FMatrix_ExtractScalingImplementation(GarbageCollectionHandle, Tolerance) as FVector;
		}

		public FVector GetScaleVector(double Tolerance = 0.00000001)
		{
			return FMatrixImplementation.FMatrix_GetScaleVectorImplementation(GarbageCollectionHandle, Tolerance) as FVector;
		}

		public FMatrix RemoveTranslation()
		{
			return FMatrixImplementation.FMatrix_RemoveTranslationImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public FMatrix ConcatTranslation(FVector InValue0)
		{
			return FMatrixImplementation.FMatrix_ConcatTranslationImplementation(GarbageCollectionHandle, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FMatrix;
		}

		public bool ContainsNaN()
		{
			return (bool)FMatrixImplementation.FMatrix_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public void ScaleTranslation(FVector InScale3D)
		{
			FMatrixImplementation.FMatrix_ScaleTranslationImplementation(GarbageCollectionHandle, InScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public double GetMinimumAxisScale()
		{
			return (double)FMatrixImplementation.FMatrix_GetMinimumAxisScaleImplementation(GarbageCollectionHandle);
		}

		public double GetMaximumAxisScale()
		{
			return (double)FMatrixImplementation.FMatrix_GetMaximumAxisScaleImplementation(GarbageCollectionHandle);
		}

		public FVector GetOrigin()
		{
			return FMatrixImplementation.FMatrix_GetOriginImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetScaledAxis(EAxis Axis)
		{
			return FMatrixImplementation.FMatrix_GetScaledAxisImplementation(GarbageCollectionHandle, Axis) as FVector;
		}

		public void GetScaledAxes(FVector X, FVector Y, FVector Z)
		{
			FMatrixImplementation.FMatrix_GetScaledAxesImplementation(GarbageCollectionHandle, X?.GarbageCollectionHandle ?? nint.Zero, Y?.GarbageCollectionHandle ?? nint.Zero, Z?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector GetUnitAxis(EAxis Axis)
		{
			return FMatrixImplementation.FMatrix_GetUnitAxisImplementation(GarbageCollectionHandle, Axis) as FVector;
		}

		public void GetUnitAxes(FVector X, FVector Y, FVector Z)
		{
			FMatrixImplementation.FMatrix_GetUnitAxesImplementation(GarbageCollectionHandle, X?.GarbageCollectionHandle ?? nint.Zero, Y?.GarbageCollectionHandle ?? nint.Zero, Z?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetAxis(int i, FVector Axis)
		{
			FMatrixImplementation.FMatrix_SetAxisImplementation(GarbageCollectionHandle, i, Axis?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetOrigin(FVector NewOrigin)
		{
			FMatrixImplementation.FMatrix_SetOriginImplementation(GarbageCollectionHandle, NewOrigin?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetAxes(FVector Axis0, FVector Axis1, FVector Axis2, FVector Origin)
		{
			FMatrixImplementation.FMatrix_SetAxesImplementation(GarbageCollectionHandle, Axis0?.GarbageCollectionHandle ?? nint.Zero, Axis1?.GarbageCollectionHandle ?? nint.Zero, Axis2?.GarbageCollectionHandle ?? nint.Zero, Origin?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector GetColumn(int i)
		{
			return FMatrixImplementation.FMatrix_GetColumnImplementation(GarbageCollectionHandle, i) as FVector;
		}

		public void GetColumn(int i, FVector Value)
		{
			FMatrixImplementation.FMatrix_GetColumn1Implementation(GarbageCollectionHandle, i, Value?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FRotator Rotator()
		{
			return FMatrixImplementation.FMatrix_RotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FQuat ToQuat()
		{
			return FMatrixImplementation.FMatrix_ToQuatImplementation(GarbageCollectionHandle) as FQuat;
		}

		public bool GetFrustumNearPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumNearPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetFrustumFarPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumFarPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetFrustumLeftPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumLeftPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetFrustumRightPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumRightPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetFrustumTopPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumTopPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool GetFrustumBottomPlane(FPlane OuTPln)
		{
			return (bool)FMatrixImplementation.FMatrix_GetFrustumBottomPlaneImplementation(GarbageCollectionHandle, OuTPln?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void Mirror(EAxis MirrorAxis, EAxis FlipAxis)
		{
			FMatrixImplementation.FMatrix_MirrorImplementation(GarbageCollectionHandle, MirrorAxis, FlipAxis);
		}

		public new FString ToString()
		{
			return FMatrixImplementation.FMatrix_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public void DebugPrint()
		{
			FMatrixImplementation.FMatrix_DebugPrintImplementation(GarbageCollectionHandle);
		}

		public uint ComputeHash()
		{
			return (uint)FMatrixImplementation.FMatrix_ComputeHashImplementation(GarbageCollectionHandle);
		}
	}
}