using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraComponent")]
	public partial class UCameraComponent : USceneComponent, IStaticClass
	{
		public float FieldOfView
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldOfView, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldOfView, __InBuffer);
				}
			}
		}

		public float OrthoWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoWidth, __InBuffer);
				}
			}
		}

		public float OrthoNearClipPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoNearClipPlane, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoNearClipPlane, __InBuffer);
				}
			}
		}

		public float OrthoFarClipPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoFarClipPlane, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrthoFarClipPlane, __InBuffer);
				}
			}
		}

		public float AspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AspectRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AspectRatio, __InBuffer);
				}
			}
		}

		public EAspectRatioAxisConstraint AspectRatioAxisConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AspectRatioAxisConstraint, __ReturnBuffer);

					return *(EAspectRatioAxisConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AspectRatioAxisConstraint, __InBuffer);
				}
			}
		}

		public bool bConstrainAspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bConstrainAspectRatio, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bConstrainAspectRatio, __InBuffer);
				}
			}
		}

		public bool bOverrideAspectRatioAxisConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAspectRatioAxisConstraint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAspectRatioAxisConstraint, __InBuffer);
				}
			}
		}

		public bool bUseFieldOfViewForLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseFieldOfViewForLOD, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseFieldOfViewForLOD, __InBuffer);
				}
			}
		}

		public bool bDrawFrustumAllowed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawFrustumAllowed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawFrustumAllowed, __InBuffer);
				}
			}
		}

		public bool bCameraMeshHiddenInGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCameraMeshHiddenInGame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCameraMeshHiddenInGame, __InBuffer);
				}
			}
		}

		public bool bLockToHmd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLockToHmd, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLockToHmd, __InBuffer);
				}
			}
		}

		public bool bUsePawnControlRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePawnControlRotation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePawnControlRotation, __InBuffer);
				}
			}
		}

		public ECameraProjectionMode ProjectionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProjectionMode, __ReturnBuffer);

					return *(ECameraProjectionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProjectionMode, __InBuffer);
				}
			}
		}

		public UStaticMesh CameraMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraMesh, __InBuffer);
				}
			}
		}

		public float PostProcessBlendWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessBlendWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessBlendWeight, __InBuffer);
				}
			}
		}

		public FPostProcessSettings PostProcessSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessSettings, __ReturnBuffer);

					return *(FPostProcessSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInUseFieldOfViewForLOD;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseFieldOfViewForLOD, __InBuffer);
			}
		}

		public virtual void SetProjectionMode(ECameraProjectionMode InProjectionMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InProjectionMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetProjectionMode, __InBuffer);
			}
		}

		public virtual void SetPostProcessBlendWeight(float InPostProcessBlendWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InPostProcessBlendWeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPostProcessBlendWeight, __InBuffer);
			}
		}

		public virtual void SetOrthoWidth(float InOrthoWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOrthoWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrthoWidth, __InBuffer);
			}
		}

		public virtual void SetOrthoNearClipPlane(float InOrthoNearClipPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOrthoNearClipPlane;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrthoNearClipPlane, __InBuffer);
			}
		}

		public virtual void SetOrthoFarClipPlane(float InOrthoFarClipPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOrthoFarClipPlane;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrthoFarClipPlane, __InBuffer);
			}
		}

		public virtual void SetFieldOfView(float InFieldOfView)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFieldOfView;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFieldOfView, __InBuffer);
			}
		}

		public virtual void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInConstrainAspectRatio;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintAspectRatio, __InBuffer);
			}
		}

		public virtual void SetAspectRatioAxisConstraint(EAspectRatioAxisConstraint InAspectRatioAxisConstraint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InAspectRatioAxisConstraint;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAspectRatioAxisConstraint, __InBuffer);
			}
		}

		public virtual void SetAspectRatio(float InAspectRatio)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InAspectRatio;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAspectRatio, __InBuffer);
			}
		}

		public virtual void RemoveBlendable(TScriptInterface<IBlendableInterface> InBlendableObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBlendableObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveBlendable, __InBuffer);
			}
		}

		public virtual void OnCameraMeshHiddenChanged()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnCameraMeshHiddenChanged);
			}
		}

		public virtual FText GetFilmbackText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFilmbackText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual void GetCameraView(float DeltaTime, ref FMinimalViewInfo DesiredView)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = DeltaTime;

				*(nint*)(__InBuffer + 4) = DesiredView?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCameraView, __InBuffer, __OutBuffer);

				DesiredView = *(FMinimalViewInfo*)(__OutBuffer);

			}
		}

		public virtual void AddOrUpdateBlendable(TScriptInterface<IBlendableInterface> InBlendableObject, float InWeight = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InBlendableObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InWeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddOrUpdateBlendable, __InBuffer);
			}
		}

		private static uint __FieldOfView = 0;

		private static uint __OrthoWidth = 0;

		private static uint __OrthoNearClipPlane = 0;

		private static uint __OrthoFarClipPlane = 0;

		private static uint __AspectRatio = 0;

		private static uint __AspectRatioAxisConstraint = 0;

		private static uint __bConstrainAspectRatio = 0;

		private static uint __bOverrideAspectRatioAxisConstraint = 0;

		private static uint __bUseFieldOfViewForLOD = 0;

		private static uint __bDrawFrustumAllowed = 0;

		private static uint __bCameraMeshHiddenInGame = 0;

		private static uint __bLockToHmd = 0;

		private static uint __bUsePawnControlRotation = 0;

		private static uint __ProjectionMode = 0;

		private static uint __CameraMesh = 0;

		private static uint __PostProcessBlendWeight = 0;

		private static uint __PostProcessSettings = 0;

		private static uint __SetUseFieldOfViewForLOD = 0;

		private static uint __SetProjectionMode = 0;

		private static uint __SetPostProcessBlendWeight = 0;

		private static uint __SetOrthoWidth = 0;

		private static uint __SetOrthoNearClipPlane = 0;

		private static uint __SetOrthoFarClipPlane = 0;

		private static uint __SetFieldOfView = 0;

		private static uint __SetConstraintAspectRatio = 0;

		private static uint __SetAspectRatioAxisConstraint = 0;

		private static uint __SetAspectRatio = 0;

		private static uint __RemoveBlendable = 0;

		private static uint __OnCameraMeshHiddenChanged = 0;

		private static uint __GetFilmbackText = 0;

		private static uint __GetCameraView = 0;

		private static uint __AddOrUpdateBlendable = 0;
	}
}