using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FTransform
	{
		public static FTransform Identity
		{
			get => FTransformImplementation.FTransform_GetIdentityImplementation(nint.Zero);
		}

		public FTransform(FVector InTranslation)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransformImplementation(this, InTranslation?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FTransform(FRotator InRotation)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransform1Implementation(this, InRotation?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FTransform(FQuat InRotation, FVector InTranslation, FVector InScale3D)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransform2Implementation(this, InRotation?.GarbageCollectionHandle ?? nint.Zero, InTranslation?.GarbageCollectionHandle ?? nint.Zero, InScale3D?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FTransform(FRotator InRotation, FVector InTranslation, FVector InScale3D)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransform3Implementation(this, InRotation?.GarbageCollectionHandle ?? nint.Zero, InTranslation?.GarbageCollectionHandle ?? nint.Zero, InScale3D?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FTransform(FMatrix InMatrix)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransform4Implementation(this, InMatrix?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FTransform(FVector InX, FVector InY, FVector InZ, FVector InTranslation)
		{
			if (GetType() == typeof(FTransform))
			{
				FTransformImplementation.FTransform_FTransform5Implementation(this, InX?.GarbageCollectionHandle ?? nint.Zero, InY?.GarbageCollectionHandle ?? nint.Zero, InZ?.GarbageCollectionHandle ?? nint.Zero, InTranslation?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FTransform operator +(FTransform InValue0, FTransform InValue1)
		{
			return FTransformImplementation.FTransform_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public static FTransform operator *(FTransform InValue0, FTransform InValue1)
		{
			return FTransformImplementation.FTransform_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public static FTransform operator *(FTransform InValue0, FQuat InValue1)
		{
			return FTransformImplementation.FTransform_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public void DebugPrint()
		{
			FTransformImplementation.FTransform_DebugPrintImplementation(GarbageCollectionHandle);
		}

		public FString ToHumanReadableString()
		{
			return FTransformImplementation.FTransform_ToHumanReadableStringImplementation(GarbageCollectionHandle) as FString;
		}

		public new FString ToString()
		{
			return FTransformImplementation.FTransform_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FTransformImplementation.FTransform_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FMatrix ToMatrixWithScale()
		{
			return FTransformImplementation.FTransform_ToMatrixWithScaleImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public FMatrix ToInverseMatrixWithScale()
		{
			return FTransformImplementation.FTransform_ToInverseMatrixWithScaleImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public FTransform Inverse()
		{
			return FTransformImplementation.FTransform_InverseImplementation(GarbageCollectionHandle) as FTransform;
		}

		public FMatrix ToMatrixNoScale()
		{
			return FTransformImplementation.FTransform_ToMatrixNoScaleImplementation(GarbageCollectionHandle) as FMatrix;
		}

		public void Blend(FTransform Atom1, FTransform Atom2, float Alpha)
		{
			FTransformImplementation.FTransform_BlendImplementation(GarbageCollectionHandle, Atom1?.GarbageCollectionHandle ?? nint.Zero, Atom2?.GarbageCollectionHandle ?? nint.Zero, Alpha);
		}

		public void BlendWith(FTransform OtherAtom, float Alpha)
		{
			FTransformImplementation.FTransform_BlendWithImplementation(GarbageCollectionHandle, OtherAtom?.GarbageCollectionHandle ?? nint.Zero, Alpha);
		}

		public static bool AnyHasNegativeScale(FVector InScale3D, FVector InOtherScale3D)
		{
			return (bool)FTransformImplementation.FTransform_AnyHasNegativeScaleImplementation(nint.Zero, InScale3D?.GarbageCollectionHandle ?? nint.Zero, InOtherScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void ScaleTranslation(FVector InScale3D)
		{
			FTransformImplementation.FTransform_ScaleTranslationImplementation(GarbageCollectionHandle, InScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void ScaleTranslation(double Scale)
		{
			FTransformImplementation.FTransform_ScaleTranslation1Implementation(GarbageCollectionHandle, Scale);
		}

		public void RemoveScaling(double Tolerance = 0.00000001)
		{
			FTransformImplementation.FTransform_RemoveScalingImplementation(GarbageCollectionHandle, Tolerance);
		}

		public float GetMaximumAxisScale()
		{
			return (float)FTransformImplementation.FTransform_GetMaximumAxisScaleImplementation(GarbageCollectionHandle);
		}

		public float GetMinimumAxisScale()
		{
			return (float)FTransformImplementation.FTransform_GetMinimumAxisScaleImplementation(GarbageCollectionHandle);
		}

		public FTransform GetRelativeTransform(FTransform Other)
		{
			return FTransformImplementation.FTransform_GetRelativeTransformImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public FTransform GetRelativeTransformReverse(FTransform Other)
		{
			return FTransformImplementation.FTransform_GetRelativeTransformReverseImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public void SetToRelativeTransform(FTransform ParentTransform)
		{
			FTransformImplementation.FTransform_SetToRelativeTransformImplementation(GarbageCollectionHandle, ParentTransform?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector4 TransformFVector4(FVector4 V)
		{
			return FTransformImplementation.FTransform_TransformFVector4Implementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public FVector4 TransformFVector4NoScale(FVector4 V)
		{
			return FTransformImplementation.FTransform_TransformFVector4NoScaleImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public FVector TransformPosition(FVector V)
		{
			return FTransformImplementation.FTransform_TransformPositionImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector TransformPositionNoScale(FVector V)
		{
			return FTransformImplementation.FTransform_TransformPositionNoScaleImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector InverseTransformPosition(FVector V)
		{
			return FTransformImplementation.FTransform_InverseTransformPositionImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector InverseTransformPositionNoScale(FVector V)
		{
			return FTransformImplementation.FTransform_InverseTransformPositionNoScaleImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector TransformVector(FVector V)
		{
			return FTransformImplementation.FTransform_TransformVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector TransformVectorNoScale(FVector V)
		{
			return FTransformImplementation.FTransform_TransformVectorNoScaleImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector InverseTransformVector(FVector V)
		{
			return FTransformImplementation.FTransform_InverseTransformVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector InverseTransformVectorNoScale(FVector V)
		{
			return FTransformImplementation.FTransform_InverseTransformVectorNoScaleImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FQuat TransformRotation(FQuat Q)
		{
			return FTransformImplementation.FTransform_TransformRotationImplementation(GarbageCollectionHandle, Q?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public FQuat InverseTransformRotation(FQuat Q)
		{
			return FTransformImplementation.FTransform_InverseTransformRotationImplementation(GarbageCollectionHandle, Q?.GarbageCollectionHandle ?? nint.Zero) as FQuat;
		}

		public FTransform GetScaled(double Scale)
		{
			return FTransformImplementation.FTransform_GetScaledImplementation(GarbageCollectionHandle, Scale) as FTransform;
		}

		public FTransform GetScaled(FVector Scale)
		{
			return FTransformImplementation.FTransform_GetScaled1Implementation(GarbageCollectionHandle, Scale?.GarbageCollectionHandle ?? nint.Zero) as FTransform;
		}

		public FVector GetScaledAxis(EAxis InAxis)
		{
			return FTransformImplementation.FTransform_GetScaledAxisImplementation(GarbageCollectionHandle, InAxis) as FVector;
		}

		public FVector GetUnitAxis(EAxis InAxis)
		{
			return FTransformImplementation.FTransform_GetUnitAxisImplementation(GarbageCollectionHandle, InAxis) as FVector;
		}

		public void Mirror(EAxis MirrorAxis, EAxis FlipAxis)
		{
			FTransformImplementation.FTransform_MirrorImplementation(GarbageCollectionHandle, MirrorAxis, FlipAxis);
		}

		public static FVector GetSafeScaleReciprocal(FVector InScale, double Tolerance = 0.00000001)
		{
			return FTransformImplementation.FTransform_GetSafeScaleReciprocalImplementation(nint.Zero, InScale?.GarbageCollectionHandle ?? nint.Zero, Tolerance) as FVector;
		}

		public FVector GetLocation()
		{
			return FTransformImplementation.FTransform_GetLocationImplementation(GarbageCollectionHandle) as FVector;
		}

		public FRotator Rotator()
		{
			return FTransformImplementation.FTransform_RotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public double GetDeterminant()
		{
			return (double)FTransformImplementation.FTransform_GetDeterminantImplementation(GarbageCollectionHandle);
		}

		public void SetLocation(FVector Origin)
		{
			FTransformImplementation.FTransform_SetLocationImplementation(GarbageCollectionHandle, Origin?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ContainsNaN()
		{
			return (bool)FTransformImplementation.FTransform_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public bool IsValid()
		{
			return (bool)FTransformImplementation.FTransform_IsValidImplementation(GarbageCollectionHandle);
		}

		public static bool AreRotationsEqual(FTransform A, FTransform B, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_AreRotationsEqualImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public static bool AreTranslationsEqual(FTransform A, FTransform B, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_AreTranslationsEqualImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public static bool AreScale3DsEqual(FTransform A, FTransform B, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_AreScale3DsEqualImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool RotationEquals(FTransform Other, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_RotationEqualsImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool TranslationEquals(FTransform Other, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_TranslationEqualsImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool Scale3DEquals(FTransform Other, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_Scale3DEqualsImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool Equals(FTransform Other, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_EqualsImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool Identical(FTransform Other, uint PortFlags)
		{
			return (bool)FTransformImplementation.FTransform_IdenticalImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, PortFlags);
		}

		public bool EqualsNoScale(FTransform Other, double Tolerance = 0.0001)
		{
			return (bool)FTransformImplementation.FTransform_EqualsNoScaleImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public static void Multiply(FTransform OutTransform, FTransform A, FTransform B)
		{
			FTransformImplementation.FTransform_MultiplyImplementation(nint.Zero, OutTransform?.GarbageCollectionHandle ?? nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetComponents(FQuat InRotation, FVector InTranslation, FVector InScale3D)
		{
			FTransformImplementation.FTransform_SetComponentsImplementation(GarbageCollectionHandle, InRotation?.GarbageCollectionHandle ?? nint.Zero, InTranslation?.GarbageCollectionHandle ?? nint.Zero, InScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetIdentity()
		{
			FTransformImplementation.FTransform_SetIdentity1Implementation(GarbageCollectionHandle);
		}

		public void SetIdentityZeroScale()
		{
			FTransformImplementation.FTransform_SetIdentityZeroScaleImplementation(GarbageCollectionHandle);
		}

		public void MultiplyScale3D(FVector Scale3DMultiplier)
		{
			FTransformImplementation.FTransform_MultiplyScale3DImplementation(GarbageCollectionHandle, Scale3DMultiplier?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetTranslation(FVector NewTranslation)
		{
			FTransformImplementation.FTransform_SetTranslationImplementation(GarbageCollectionHandle, NewTranslation?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void CopyTranslation(FTransform Other)
		{
			FTransformImplementation.FTransform_CopyTranslationImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void ConcatenateRotation(FQuat DeltaRotation)
		{
			FTransformImplementation.FTransform_ConcatenateRotationImplementation(GarbageCollectionHandle, DeltaRotation?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void AddToTranslation(FVector DeltaTranslation)
		{
			FTransformImplementation.FTransform_AddToTranslationImplementation(GarbageCollectionHandle, DeltaTranslation?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector AddTranslations(FTransform A, FTransform B)
		{
			return FTransformImplementation.FTransform_AddTranslationsImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public static FVector SubtractTranslations(FTransform A, FTransform B)
		{
			return FTransformImplementation.FTransform_SubtractTranslationsImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public void SetRotation(FQuat NewRotation)
		{
			FTransformImplementation.FTransform_SetRotationImplementation(GarbageCollectionHandle, NewRotation?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void CopyRotation(FTransform Other)
		{
			FTransformImplementation.FTransform_CopyRotationImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetScale3D(FVector NewScale3D)
		{
			FTransformImplementation.FTransform_SetScale3DImplementation(GarbageCollectionHandle, NewScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void CopyScale3D(FTransform Other)
		{
			FTransformImplementation.FTransform_CopyScale3DImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetTranslationAndScale3D(FVector NewTranslation, FVector NewScale3D)
		{
			FTransformImplementation.FTransform_SetTranslationAndScale3DImplementation(GarbageCollectionHandle, NewTranslation?.GarbageCollectionHandle ?? nint.Zero, NewScale3D?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void Accumulate(FTransform SourceAtom)
		{
			FTransformImplementation.FTransform_AccumulateImplementation(GarbageCollectionHandle, SourceAtom?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void NormalizeRotation()
		{
			FTransformImplementation.FTransform_NormalizeRotationImplementation(GarbageCollectionHandle);
		}

		public bool IsRotationNormalized()
		{
			return (bool)FTransformImplementation.FTransform_IsRotationNormalizedImplementation(GarbageCollectionHandle);
		}

		public FQuat GetRotation()
		{
			return FTransformImplementation.FTransform_GetRotationImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FVector GetTranslation()
		{
			return FTransformImplementation.FTransform_GetTranslationImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetScale3D()
		{
			return FTransformImplementation.FTransform_GetScale3DImplementation(GarbageCollectionHandle) as FVector;
		}

		public void CopyRotationPart(FTransform SrcBA)
		{
			FTransformImplementation.FTransform_CopyRotationPartImplementation(GarbageCollectionHandle, SrcBA?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void CopyTranslationAndScale3D(FTransform SrcBA)
		{
			FTransformImplementation.FTransform_CopyTranslationAndScale3DImplementation(GarbageCollectionHandle, SrcBA?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void SetFromMatrix(FMatrix InMatrix)
		{
			FTransformImplementation.FTransform_SetFromMatrixImplementation(GarbageCollectionHandle, InMatrix?.GarbageCollectionHandle ?? nint.Zero);
		}
	}
}