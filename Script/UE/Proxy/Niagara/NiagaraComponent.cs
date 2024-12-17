using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraComponent")]
	public partial class UNiagaraComponent : UFXSystemComponent, IStaticClass
	{
		public UNiagaraSystem Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(UNiagaraSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Asset, __InBuffer);
				}
			}
		}

		public ENiagaraTickBehavior TickBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickBehavior, __ReturnBuffer);

					return *(ENiagaraTickBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickBehavior, __InBuffer);
				}
			}
		}

		public int RandomSeedOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeedOffset, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeedOffset, __InBuffer);
				}
			}
		}

		public FNiagaraUserRedirectionParameterStore OverrideParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideParameters, __ReturnBuffer);

					return *(FNiagaraUserRedirectionParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideParameters, __InBuffer);
				}
			}
		}

		public TMap<FNiagaraVariableBase, FNiagaraVariant> TemplateParameterOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateParameterOverrides, __ReturnBuffer);

					return *(TMap<FNiagaraVariableBase, FNiagaraVariant>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateParameterOverrides, __InBuffer);
				}
			}
		}

		public TMap<FNiagaraVariableBase, FNiagaraVariant> InstanceParameterOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameterOverrides, __ReturnBuffer);

					return *(TMap<FNiagaraVariableBase, FNiagaraVariant>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameterOverrides, __InBuffer);
				}
			}
		}

		public bool bForceSolo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSolo, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSolo, __InBuffer);
				}
			}
		}

		public bool bEnableGpuComputeDebug
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGpuComputeDebug, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGpuComputeDebug, __InBuffer);
				}
			}
		}

		public bool bOverrideWarmupSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideWarmupSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideWarmupSettings, __InBuffer);
				}
			}
		}

		public int WarmupTickCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickCount, __InBuffer);
				}
			}
		}

		public float WarmupTickDelta
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickDelta, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickDelta, __InBuffer);
				}
			}
		}

		public bool bAutoDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __InBuffer);
				}
			}
		}

		public bool bRenderingEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderingEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderingEnabled, __InBuffer);
				}
			}
		}

		public bool bAutoManageAttachment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageAttachment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageAttachment, __InBuffer);
				}
			}
		}

		public bool bAutoAttachWeldSimulatedBodies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoAttachWeldSimulatedBodies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoAttachWeldSimulatedBodies, __InBuffer);
				}
			}
		}

		public float MaxTimeBeforeForceUpdateTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTimeBeforeForceUpdateTransform, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTimeBeforeForceUpdateTransform, __InBuffer);
				}
			}
		}

		public ENiagaraOcclusionQueryMode OcclusionQueryMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OcclusionQueryMode, __ReturnBuffer);

					return *(ENiagaraOcclusionQueryMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OcclusionQueryMode, __InBuffer);
				}
			}
		}

		public FOnNiagaraSystemFinished OnSystemFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSystemFinished, __ReturnBuffer);

					return *(FOnNiagaraSystemFinished*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSystemFinished, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USceneComponent> AutoAttachParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachParent, __ReturnBuffer);

					return *(TWeakObjectPtr<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachParent, __InBuffer);
				}
			}
		}

		public FName AutoAttachSocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachSocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachSocketName, __InBuffer);
				}
			}
		}

		public EAttachmentRule AutoAttachLocationRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachLocationRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachLocationRule, __InBuffer);
				}
			}
		}

		public EAttachmentRule AutoAttachRotationRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachRotationRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachRotationRule, __InBuffer);
				}
			}
		}

		public EAttachmentRule AutoAttachScaleRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachScaleRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachScaleRule, __InBuffer);
				}
			}
		}

		public bool bWaitForCompilationOnActivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForCompilationOnActivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForCompilationOnActivate, __InBuffer);
				}
			}
		}

		public bool bAllowScalability
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowScalability, __InBuffer);
				}
			}
		}

		public UNiagaraSimCache SimCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimCache, __ReturnBuffer);

					return *(UNiagaraSimCache*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimCache, __InBuffer);
				}
			}
		}

		public UNiagaraCullProxyComponent CullProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CullProxy, __ReturnBuffer);

					return *(UNiagaraCullProxyComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CullProxy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVariableVec4(FName InVariableName, FVector4 InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableVec4, __InBuffer);
			}
		}

		public virtual void SetVariableVec3(FName InVariableName, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableVec3, __InBuffer);
			}
		}

		public virtual void SetVariableVec2(FName InVariableName, FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableVec2, __InBuffer);
			}
		}

		public virtual void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget TextureRenderTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextureRenderTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableTextureRenderTarget, __InBuffer);
			}
		}

		public virtual void SetVariableTexture(FName InVariableName, UTexture Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableTexture, __InBuffer);
			}
		}

		public virtual void SetVariableStaticMesh(FName InVariableName, UStaticMesh InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableStaticMesh, __InBuffer);
			}
		}

		public virtual void SetVariableQuat(FName InVariableName, FQuat InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableQuat, __InBuffer);
			}
		}

		public virtual void SetVariablePosition(FName InVariableName, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariablePosition, __InBuffer);
			}
		}

		public virtual void SetVariableObject(FName InVariableName, UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableObject, __InBuffer);
			}
		}

		public virtual void SetVariableMatrix(FName InVariableName, FMatrix InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableMatrix, __InBuffer);
			}
		}

		public virtual void SetVariableMaterial(FName InVariableName, UMaterialInterface Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableMaterial, __InBuffer);
			}
		}

		public virtual void SetVariableLinearColor(FName InVariableName, FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableLinearColor, __InBuffer);
			}
		}

		public virtual void SetVariableInt(FName InVariableName, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableInt, __InBuffer);
			}
		}

		public virtual void SetVariableFloat(FName InVariableName, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableFloat, __InBuffer);
			}
		}

		public virtual void SetVariableBool(FName InVariableName, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableBool, __InBuffer);
			}
		}

		public virtual void SetVariableActor(FName InVariableName, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVariableActor, __InBuffer);
			}
		}

		public virtual void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewTickBehavior;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTickBehavior, __InBuffer);
			}
		}

		public virtual void SetSystemFixedBounds(FBox LocalBounds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LocalBounds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSystemFixedBounds, __InBuffer);
			}
		}

		public virtual void SetSimCache(UNiagaraSimCache SimCache, bool bResetSystem = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bResetSystem;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSimCache, __InBuffer);
			}
		}

		public virtual void SetSeekDelta(float InSeekDelta)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSeekDelta;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSeekDelta, __InBuffer);
			}
		}

		public virtual void SetRenderingEnabled(bool bInRenderingEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInRenderingEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderingEnabled, __InBuffer);
			}
		}

		public virtual void SetRandomSeedOffset(int NewRandomSeedOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewRandomSeedOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRandomSeedOffset, __InBuffer);
			}
		}

		public virtual void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance, float PreviewMaxDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bEnablePreviewLODDistance;

				*(float*)(__InBuffer + 1) = PreviewLODDistance;

				*(float*)(__InBuffer + 5) = PreviewMaxDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreviewLODDistance, __InBuffer);
			}
		}

		public virtual void SetPaused(bool bInPaused)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInPaused;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPaused, __InBuffer);
			}
		}

		public virtual void SetOcclusionQueryMode(ENiagaraOcclusionQueryMode Mode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Mode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOcclusionQueryMode, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableVec4(FString InVariableName, FVector4 InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableVec4, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableVec3(FString InVariableName, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableVec3, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableVec2(FString InVariableName, FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableVec2, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableQuat(FString InVariableName, FQuat InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableQuat, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariablePosition(FString InVariableName, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariablePosition, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableObject(FString InVariableName, UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableObject, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableMatrix(FString InVariableName, FMatrix InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableMatrix, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableLinearColor(FString InVariableName, FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableLinearColor, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableInt(FString InVariableName, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableInt, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableFloat(FString InVariableName, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableFloat, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableBool(FString InVariableName, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableBool, __InBuffer);
			}
		}

		public virtual void SetNiagaraVariableActor(FString InVariableName, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNiagaraVariableActor, __InBuffer);
			}
		}

		public virtual void SetMaxSimTime(float InMaxTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMaxTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaxSimTime, __InBuffer);
			}
		}

		public virtual void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bLock;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLockDesiredAgeDeltaTimeToSeekDelta, __InBuffer);
			}
		}

		public virtual void SetGpuComputeDebug(bool bEnableDebug)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnableDebug;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGpuComputeDebug, __InBuffer);
			}
		}

		public virtual void SetForceSolo(bool bInForceSolo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInForceSolo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceSolo, __InBuffer);
			}
		}

		public virtual void SetForceLocalPlayerEffect(bool bIsPlayerEffect)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsPlayerEffect;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceLocalPlayerEffect, __InBuffer);
			}
		}

		public virtual void SetEmitterFixedBounds(FName EmitterName, FBox LocalBounds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LocalBounds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEmitterFixedBounds, __InBuffer);
			}
		}

		public virtual void SetDesiredAge(float InDesiredAge)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDesiredAge;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDesiredAge, __InBuffer);
			}
		}

		public virtual void SetCustomTimeDilation(float Dilation = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Dilation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomTimeDilation, __InBuffer);
			}
		}

		public virtual void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInCanRenderWhileSeeking;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCanRenderWhileSeeking, __InBuffer);
			}
		}

		public virtual void SetAutoDestroy(bool bInAutoDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInAutoDestroy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoDestroy, __InBuffer);
			}
		}

		public virtual void SetAsset(UNiagaraSystem InAsset, bool bResetExistingOverrideParameters = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bResetExistingOverrideParameters;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAsset, __InBuffer);
			}
		}

		public virtual void SetAllowScalability(bool bAllow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bAllow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowScalability, __InBuffer);
			}
		}

		public virtual void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InAgeUpdateMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAgeUpdateMode, __InBuffer);
			}
		}

		public virtual void SeekToDesiredAge(float InDesiredAge)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDesiredAge;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SeekToDesiredAge, __InBuffer);
			}
		}

		public virtual void ResetSystem()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetSystem);
			}
		}

		public virtual void ReinitializeSystem()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReinitializeSystem);
			}
		}

		public virtual bool IsPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void InitForPerformanceBaseline()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __InitForPerformanceBaseline);
			}
		}

		public virtual ENiagaraTickBehavior GetTickBehavior()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTickBehavior, __ReturnBuffer);

				return *(ENiagaraTickBehavior*)__ReturnBuffer;
			}
		}

		public virtual FBox GetSystemFixedBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSystemFixedBounds, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraSimCache GetSimCache()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSimCache, __ReturnBuffer);

				return *(UNiagaraSimCache*)__ReturnBuffer;
			}
		}

		public virtual float GetSeekDelta()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSeekDelta, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual int GetRandomSeedOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRandomSeedOffset, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool GetPreviewLODDistanceEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPreviewLODDistanceEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetPreviewLODDistance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPreviewLODDistance, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual ENiagaraOcclusionQueryMode GetOcclusionQueryMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOcclusionQueryMode, __ReturnBuffer);

				return *(ENiagaraOcclusionQueryMode*)__ReturnBuffer;
			}
		}

		public virtual TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(FString InEmitterName, FString InValueName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InEmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValueName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNiagaraParticleValueVec3_DebugOnly, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public virtual TArray<float> GetNiagaraParticleValues_DebugOnly(FString InEmitterName, FString InValueName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InEmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValueName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNiagaraParticleValues_DebugOnly, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FVector> GetNiagaraParticlePositions_DebugOnly(FString InEmitterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEmitterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNiagaraParticlePositions_DebugOnly, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxSimTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxSimTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetLockDesiredAgeDeltaTimeToSeekDelta()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLockDesiredAgeDeltaTimeToSeekDelta, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetForceSolo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetForceSolo, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetForceLocalPlayerEffect()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetForceLocalPlayerEffect, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FBox GetEmitterFixedBounds(FName EmitterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetEmitterFixedBounds, __InBuffer, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public virtual float GetDesiredAge()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDesiredAge, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraDataInterface GetDataInterface(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataInterface, __InBuffer, __ReturnBuffer);

				return *(UNiagaraDataInterface*)__ReturnBuffer;
			}
		}

		public virtual float GetCustomTimeDilation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCustomTimeDilation, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraSystem GetAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAsset, __ReturnBuffer);

				return *(UNiagaraSystem*)__ReturnBuffer;
			}
		}

		public virtual bool GetAllowScalability()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAllowScalability, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual ENiagaraAgeUpdateMode GetAgeUpdateMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAgeUpdateMode, __ReturnBuffer);

				return *(ENiagaraAgeUpdateMode*)__ReturnBuffer;
			}
		}

		public virtual void ClearSystemFixedBounds()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSystemFixedBounds);
			}
		}

		public virtual void ClearSimCache(bool bResetSystem = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bResetSystem;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearSimCache, __InBuffer);
			}
		}

		public virtual void ClearEmitterFixedBounds(FName EmitterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearEmitterFixedBounds, __InBuffer);
			}
		}

		public virtual void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = SimulateTime;

				*(float*)(__InBuffer + 4) = TickDeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdvanceSimulationByTime, __InBuffer);
			}
		}

		public virtual void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TickCount;

				*(float*)(__InBuffer + 4) = TickDeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdvanceSimulation, __InBuffer);
			}
		}

		private static uint __Asset = 0;

		private static uint __TickBehavior = 0;

		private static uint __RandomSeedOffset = 0;

		private static uint __OverrideParameters = 0;

		private static uint __TemplateParameterOverrides = 0;

		private static uint __InstanceParameterOverrides = 0;

		private static uint __bForceSolo = 0;

		private static uint __bEnableGpuComputeDebug = 0;

		private static uint __bOverrideWarmupSettings = 0;

		private static uint __WarmupTickCount = 0;

		private static uint __WarmupTickDelta = 0;

		private static uint __bAutoDestroy = 0;

		private static uint __bRenderingEnabled = 0;

		private static uint __bAutoManageAttachment = 0;

		private static uint __bAutoAttachWeldSimulatedBodies = 0;

		private static uint __MaxTimeBeforeForceUpdateTransform = 0;

		private static uint __OcclusionQueryMode = 0;

		private static uint __OnSystemFinished = 0;

		private static uint __AutoAttachParent = 0;

		private static uint __AutoAttachSocketName = 0;

		private static uint __AutoAttachLocationRule = 0;

		private static uint __AutoAttachRotationRule = 0;

		private static uint __AutoAttachScaleRule = 0;

		private static uint __bWaitForCompilationOnActivate = 0;

		private static uint __bAllowScalability = 0;

		private static uint __SimCache = 0;

		private static uint __CullProxy = 0;

		private static uint __SetVariableVec4 = 0;

		private static uint __SetVariableVec3 = 0;

		private static uint __SetVariableVec2 = 0;

		private static uint __SetVariableTextureRenderTarget = 0;

		private static uint __SetVariableTexture = 0;

		private static uint __SetVariableStaticMesh = 0;

		private static uint __SetVariableQuat = 0;

		private static uint __SetVariablePosition = 0;

		private static uint __SetVariableObject = 0;

		private static uint __SetVariableMatrix = 0;

		private static uint __SetVariableMaterial = 0;

		private static uint __SetVariableLinearColor = 0;

		private static uint __SetVariableInt = 0;

		private static uint __SetVariableFloat = 0;

		private static uint __SetVariableBool = 0;

		private static uint __SetVariableActor = 0;

		private static uint __SetTickBehavior = 0;

		private static uint __SetSystemFixedBounds = 0;

		private static uint __SetSimCache = 0;

		private static uint __SetSeekDelta = 0;

		private static uint __SetRenderingEnabled = 0;

		private static uint __SetRandomSeedOffset = 0;

		private static uint __SetPreviewLODDistance = 0;

		private static uint __SetPaused = 0;

		private static uint __SetOcclusionQueryMode = 0;

		private static uint __SetNiagaraVariableVec4 = 0;

		private static uint __SetNiagaraVariableVec3 = 0;

		private static uint __SetNiagaraVariableVec2 = 0;

		private static uint __SetNiagaraVariableQuat = 0;

		private static uint __SetNiagaraVariablePosition = 0;

		private static uint __SetNiagaraVariableObject = 0;

		private static uint __SetNiagaraVariableMatrix = 0;

		private static uint __SetNiagaraVariableLinearColor = 0;

		private static uint __SetNiagaraVariableInt = 0;

		private static uint __SetNiagaraVariableFloat = 0;

		private static uint __SetNiagaraVariableBool = 0;

		private static uint __SetNiagaraVariableActor = 0;

		private static uint __SetMaxSimTime = 0;

		private static uint __SetLockDesiredAgeDeltaTimeToSeekDelta = 0;

		private static uint __SetGpuComputeDebug = 0;

		private static uint __SetForceSolo = 0;

		private static uint __SetForceLocalPlayerEffect = 0;

		private static uint __SetEmitterFixedBounds = 0;

		private static uint __SetDesiredAge = 0;

		private static uint __SetCustomTimeDilation = 0;

		private static uint __SetCanRenderWhileSeeking = 0;

		private static uint __SetAutoDestroy = 0;

		private static uint __SetAsset = 0;

		private static uint __SetAllowScalability = 0;

		private static uint __SetAgeUpdateMode = 0;

		private static uint __SeekToDesiredAge = 0;

		private static uint __ResetSystem = 0;

		private static uint __ReinitializeSystem = 0;

		private static uint __IsPaused = 0;

		private static uint __InitForPerformanceBaseline = 0;

		private static uint __GetTickBehavior = 0;

		private static uint __GetSystemFixedBounds = 0;

		private static uint __GetSimCache = 0;

		private static uint __GetSeekDelta = 0;

		private static uint __GetRandomSeedOffset = 0;

		private static uint __GetPreviewLODDistanceEnabled = 0;

		private static uint __GetPreviewLODDistance = 0;

		private static uint __GetOcclusionQueryMode = 0;

		private static uint __GetNiagaraParticleValueVec3_DebugOnly = 0;

		private static uint __GetNiagaraParticleValues_DebugOnly = 0;

		private static uint __GetNiagaraParticlePositions_DebugOnly = 0;

		private static uint __GetMaxSimTime = 0;

		private static uint __GetLockDesiredAgeDeltaTimeToSeekDelta = 0;

		private static uint __GetForceSolo = 0;

		private static uint __GetForceLocalPlayerEffect = 0;

		private static uint __GetEmitterFixedBounds = 0;

		private static uint __GetDesiredAge = 0;

		private static uint __GetDataInterface = 0;

		private static uint __GetCustomTimeDilation = 0;

		private static uint __GetAsset = 0;

		private static uint __GetAllowScalability = 0;

		private static uint __GetAgeUpdateMode = 0;

		private static uint __ClearSystemFixedBounds = 0;

		private static uint __ClearSimCache = 0;

		private static uint __ClearEmitterFixedBounds = 0;

		private static uint __AdvanceSimulationByTime = 0;

		private static uint __AdvanceSimulation = 0;
	}
}