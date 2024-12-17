using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigComponent")]
	public partial class UControlRigComponent : UPrimitiveComponent, IStaticClass
	{
		public TSubclassOf<UControlRig> ControlRigClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigClass, __ReturnBuffer);

					return *(TSubclassOf<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigClass, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPreInitializeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreInitializeDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreInitializeDelegate, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPostInitializeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostInitializeDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostInitializeDelegate, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPreConstructionDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreConstructionDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreConstructionDelegate, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPostConstructionDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostConstructionDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostConstructionDelegate, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPreForwardsSolveDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreForwardsSolveDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreForwardsSolveDelegate, __InBuffer);
				}
			}
		}

		public FControlRigComponentDelegate OnPostForwardsSolveDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostForwardsSolveDelegate, __ReturnBuffer);

					return *(FControlRigComponentDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostForwardsSolveDelegate, __InBuffer);
				}
			}
		}

		public TArray<FControlRigComponentMappedElement> UserDefinedElements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserDefinedElements, __ReturnBuffer);

					return *(TArray<FControlRigComponentMappedElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserDefinedElements, __InBuffer);
				}
			}
		}

		public TArray<FControlRigComponentMappedElement> MappedElements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MappedElements, __ReturnBuffer);

					return *(TArray<FControlRigComponentMappedElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MappedElements, __InBuffer);
				}
			}
		}

		public bool bEnableLazyEvaluation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLazyEvaluation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLazyEvaluation, __InBuffer);
				}
			}
		}

		public float LazyEvaluationPositionThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationPositionThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationPositionThreshold, __InBuffer);
				}
			}
		}

		public float LazyEvaluationRotationThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationRotationThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationRotationThreshold, __InBuffer);
				}
			}
		}

		public float LazyEvaluationScaleThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationScaleThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LazyEvaluationScaleThreshold, __InBuffer);
				}
			}
		}

		public bool bResetTransformBeforeTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetTransformBeforeTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetTransformBeforeTick, __InBuffer);
				}
			}
		}

		public bool bResetInitialsBeforeConstruction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetInitialsBeforeConstruction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetInitialsBeforeConstruction, __InBuffer);
				}
			}
		}

		public bool bUpdateRigOnTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateRigOnTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateRigOnTick, __InBuffer);
				}
			}
		}

		public bool bUpdateInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateInEditor, __InBuffer);
				}
			}
		}

		public bool bDrawBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawBones, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawBones, __InBuffer);
				}
			}
		}

		public bool bShowDebugDrawing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowDebugDrawing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowDebugDrawing, __InBuffer);
				}
			}
		}

		public UControlRig ControlRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRig, __ReturnBuffer);

					return *(UControlRig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRig, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Update(float DeltaTime = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Update, __InBuffer);
			}
		}

		public virtual void SetObjectBinding(UObject InObjectToBind)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObjectToBind?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetObjectBinding, __InBuffer);
			}
		}

		public virtual void SetMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMappedElements?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMappedElements, __InBuffer);
			}
		}

		/// <param name="SpaceName">
		/// The name of the space to set the transform for
		/// </param>
		/// <param name="Space">
		/// The space to set the transform in
		/// </param>
		public virtual void SetInitialSpaceTransform(FName SpaceName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SpaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InitialTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInitialSpaceTransform, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// The name of the bone to set the transform for
		/// </param>
		/// <param name="InitialTransform">
		/// The initial transform to set for the bone
		/// </param>
		/// <param name="Space">
		/// The space to set the transform in
		/// </param>
		/// <param name="bPropagateToChildren">
		/// If true the child bones will be moved together with the affected bone
		/// </param>
		public virtual void SetInitialBoneTransform(FName BoneName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, bool bPropagateToChildren = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InitialTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				*(bool*)(__InBuffer + 17) = bPropagateToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInitialBoneTransform, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		public virtual void SetControlVector2D(FName ControlName, FVector2D Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlVector2D, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		/// <param name="Space">
		/// The space to set the value in
		/// </param>
		public virtual void SetControlTransform(FName ControlName, FTransform Value, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlTransform, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		/// <param name="Space">
		/// The space to set the value in
		/// </param>
		public virtual void SetControlScale(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlScale, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		/// <param name="Space">
		/// The space to set the value in
		/// </param>
		public virtual void SetControlRotator(FName ControlName, FRotator Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlRotator, __InBuffer);
			}
		}

		public virtual void SetControlRigClass(TSubclassOf<UControlRig> InControlRigClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InControlRigClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlRigClass, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		/// <param name="Space">
		/// The space to set the value in
		/// </param>
		public virtual void SetControlPosition(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPosition, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="OffsetTransform">
		/// The new offset trasnform for the control
		/// </param>
		/// <param name="Space">
		/// The space to set the offset transform in
		/// </param>
		public virtual void SetControlOffset(FName ControlName, FTransform OffsetTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OffsetTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlOffset, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		public virtual void SetControlInt(FName ControlName, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlInt, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		public virtual void SetControlFloat(FName ControlName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlFloat, __InBuffer);
			}
		}

		/// <param name="ControlName">
		/// The name of the control to set
		/// </param>
		/// <param name="Value">
		/// The new value for the control
		/// </param>
		public virtual void SetControlBool(FName ControlName, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlBool, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// The name of the bone to set the transform for
		/// </param>
		/// <param name="Space">
		/// The space to set the transform in
		/// </param>
		/// <param name="Weight">
		/// The weight of how much the change should be applied (0.0 to 1.0)
		/// </param>
		/// <param name="bPropagateToChildren">
		/// If true the child bones will be moved together with the affected bone
		/// </param>
		public virtual void SetBoneTransform(FName BoneName, FTransform Transform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, float Weight = 1.000000f, bool bPropagateToChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				*(float*)(__InBuffer + 17) = Weight;

				*(bool*)(__InBuffer + 21) = bPropagateToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneTransform, __InBuffer);
			}
		}

		public virtual void SetBoneInitialTransformsFromSkeletalMesh(USkeletalMesh InSkeletalMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneInitialTransformsFromSkeletalMesh, __InBuffer);
			}
		}

		public virtual void OnPreInitialize(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPreInitialize, __InBuffer);
			}
		}

		public virtual void OnPreForwardsSolve(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPreForwardsSolve, __InBuffer);
			}
		}

		public virtual void OnPreConstruction(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPreConstruction, __InBuffer);
			}
		}

		public virtual void OnPostInitialize(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPostInitialize, __InBuffer);
			}
		}

		public virtual void OnPostForwardsSolve(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPostForwardsSolve, __InBuffer);
			}
		}

		public virtual void OnPostConstruction(UControlRigComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPostConstruction, __InBuffer);
			}
		}

		public virtual void Initialize()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Initialize);
			}
		}

		/// <param name="SpaceName">
		/// The name of the space to retrieve the transform for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the transform in
		/// </param>
		/// <returns>
		/// the transform of the space in the requested space
		/// </returns>
		public virtual FTransform GetSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SpaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSpaceTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="SpaceName">
		/// The name of the space to retrieve the transform for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the transform in
		/// </param>
		/// <returns>
		/// the initial transform of the space in the requested space
		/// </returns>
		public virtual FTransform GetInitialSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SpaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInitialSpaceTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// The name of the bone to retrieve the transform for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the transform in
		/// </param>
		/// <returns>
		/// the initial transform of the bone in the requested space
		/// </returns>
		public virtual FTransform GetInitialBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInitialBoneTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="ElementType">
		/// The type of elements to return the names for
		/// </param>
		/// <returns>
		/// all of the names for a given element type (Bone, Control, etc)
		/// </returns>
		public virtual TArray<FName> GetElementNames(ERigElementType ElementType = ERigElementType.Bone)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ElementType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetElementNames, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <returns>
		/// The Vector3D value of the control
		/// </returns>
		public virtual FVector2D GetControlVector2D(FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the control's value in
		/// </param>
		/// <returns>
		/// The transform value of the control
		/// </returns>
		public virtual FTransform GetControlTransform(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the control's value in
		/// </param>
		/// <returns>
		/// The scale value of the control
		/// </returns>
		public virtual FVector GetControlScale(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlScale, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the control's value in
		/// </param>
		/// <returns>
		/// The rotator value of the control
		/// </returns>
		public virtual FRotator GetControlRotator(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual UControlRig GetControlRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlRig, __ReturnBuffer);

				return *(UControlRig*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the control's value in
		/// </param>
		/// <returns>
		/// The position value of the control
		/// </returns>
		public virtual FVector GetControlPosition(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the offset transform for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the offset transform in
		/// </param>
		/// <returns>
		/// The offset transform of a control 
		/// </returns>
		public virtual FTransform GetControlOffset(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlOffset, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <returns>
		/// The int32 value of the control
		/// </returns>
		public virtual int GetControlInt(FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControlInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <returns>
		/// The float value of the control
		/// </returns>
		public virtual float GetControlFloat(FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControlFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="ControlName">
		/// The name of the control to retrieve the value for
		/// </param>
		/// <returns>
		/// The bool value of the control
		/// </returns>
		public virtual bool GetControlBool(FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControlBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// The name of the bone to retrieve the transform for
		/// </param>
		/// <param name="Space">
		/// The space to retrieve the transform in
		/// </param>
		/// <returns>
		/// the transform of the bone in the requested space
		/// </returns>
		public virtual FTransform GetBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual float GetAbsoluteTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAbsoluteTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// The name for the element to look up
		/// </param>
		/// <param name="ElementType">
		/// The type of element to look up
		/// </param>
		/// <returns>
		/// true if the element exists
		/// </returns>
		public virtual bool DoesElementExist(FName Name, ERigElementType ElementType = ERigElementType.Bone)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ElementType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesElementExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ClearMappedElements()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearMappedElements);
			}
		}

		public virtual bool CanExecute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanExecute, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddMappedSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent, TArray<FControlRigComponentMappedBone> Bones, TArray<FControlRigComponentMappedCurve> Curves)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Bones?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Curves?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMappedSkeletalMesh, __InBuffer);
			}
		}

		public virtual void AddMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMappedElements?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMappedElements, __InBuffer);
			}
		}

		public virtual void AddMappedComponents(TArray<FControlRigComponentMappedComponent> Components)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Components?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMappedComponents, __InBuffer);
			}
		}

		public virtual void AddMappedCompleteSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMappedCompleteSkeletalMesh, __InBuffer);
			}
		}

		private static uint __ControlRigClass = 0;

		private static uint __OnPreInitializeDelegate = 0;

		private static uint __OnPostInitializeDelegate = 0;

		private static uint __OnPreConstructionDelegate = 0;

		private static uint __OnPostConstructionDelegate = 0;

		private static uint __OnPreForwardsSolveDelegate = 0;

		private static uint __OnPostForwardsSolveDelegate = 0;

		private static uint __UserDefinedElements = 0;

		private static uint __MappedElements = 0;

		private static uint __bEnableLazyEvaluation = 0;

		private static uint __LazyEvaluationPositionThreshold = 0;

		private static uint __LazyEvaluationRotationThreshold = 0;

		private static uint __LazyEvaluationScaleThreshold = 0;

		private static uint __bResetTransformBeforeTick = 0;

		private static uint __bResetInitialsBeforeConstruction = 0;

		private static uint __bUpdateRigOnTick = 0;

		private static uint __bUpdateInEditor = 0;

		private static uint __bDrawBones = 0;

		private static uint __bShowDebugDrawing = 0;

		private static uint __ControlRig = 0;

		private static uint __Update = 0;

		private static uint __SetObjectBinding = 0;

		private static uint __SetMappedElements = 0;

		private static uint __SetInitialSpaceTransform = 0;

		private static uint __SetInitialBoneTransform = 0;

		private static uint __SetControlVector2D = 0;

		private static uint __SetControlTransform = 0;

		private static uint __SetControlScale = 0;

		private static uint __SetControlRotator = 0;

		private static uint __SetControlRigClass = 0;

		private static uint __SetControlPosition = 0;

		private static uint __SetControlOffset = 0;

		private static uint __SetControlInt = 0;

		private static uint __SetControlFloat = 0;

		private static uint __SetControlBool = 0;

		private static uint __SetBoneTransform = 0;

		private static uint __SetBoneInitialTransformsFromSkeletalMesh = 0;

		private static uint __OnPreInitialize = 0;

		private static uint __OnPreForwardsSolve = 0;

		private static uint __OnPreConstruction = 0;

		private static uint __OnPostInitialize = 0;

		private static uint __OnPostForwardsSolve = 0;

		private static uint __OnPostConstruction = 0;

		private static uint __Initialize = 0;

		private static uint __GetSpaceTransform = 0;

		private static uint __GetInitialSpaceTransform = 0;

		private static uint __GetInitialBoneTransform = 0;

		private static uint __GetElementNames = 0;

		private static uint __GetControlVector2D = 0;

		private static uint __GetControlTransform = 0;

		private static uint __GetControlScale = 0;

		private static uint __GetControlRotator = 0;

		private static uint __GetControlRig = 0;

		private static uint __GetControlPosition = 0;

		private static uint __GetControlOffset = 0;

		private static uint __GetControlInt = 0;

		private static uint __GetControlFloat = 0;

		private static uint __GetControlBool = 0;

		private static uint __GetBoneTransform = 0;

		private static uint __GetAbsoluteTime = 0;

		private static uint __DoesElementExist = 0;

		private static uint __ClearMappedElements = 0;

		private static uint __CanExecute = 0;

		private static uint __AddMappedSkeletalMesh = 0;

		private static uint __AddMappedElements = 0;

		private static uint __AddMappedComponents = 0;

		private static uint __AddMappedCompleteSkeletalMesh = 0;
	}
}