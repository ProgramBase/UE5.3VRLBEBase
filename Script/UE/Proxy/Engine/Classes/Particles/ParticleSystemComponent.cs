using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSystemComponent")]
	public partial class UParticleSystemComponent : UFXSystemComponent, IStaticClass
	{
		public UParticleSystem Template
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Template, __ReturnBuffer);

					return *(UParticleSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Template, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> EmitterMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterMaterials, __InBuffer);
				}
			}
		}

		public TArray<USkeletalMeshComponent> SkelMeshComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMeshComponents, __ReturnBuffer);

					return *(TArray<USkeletalMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMeshComponents, __InBuffer);
				}
			}
		}

		public bool bResetOnDetach
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetOnDetach, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetOnDetach, __InBuffer);
				}
			}
		}

		public bool bUpdateOnDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOnDedicatedServer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOnDedicatedServer, __InBuffer);
				}
			}
		}

		public bool bAllowRecycling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRecycling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRecycling, __InBuffer);
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

		public bool bWarmingUp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWarmingUp, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWarmingUp, __InBuffer);
				}
			}
		}

		public bool bOverrideLODMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLODMethod, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLODMethod, __InBuffer);
				}
			}
		}

		public bool bSkipUpdateDynamicDataDuringTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipUpdateDynamicDataDuringTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipUpdateDynamicDataDuringTick, __InBuffer);
				}
			}
		}

		public ParticleSystemLODMethod LODMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODMethod, __ReturnBuffer);

					return *(ParticleSystemLODMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODMethod, __InBuffer);
				}
			}
		}

		public EParticleSignificanceLevel RequiredSignificance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequiredSignificance, __ReturnBuffer);

					return *(EParticleSignificanceLevel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequiredSignificance, __InBuffer);
				}
			}
		}

		public TArray<FParticleSysParam> InstanceParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameters, __ReturnBuffer);

					return *(TArray<FParticleSysParam>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameters, __InBuffer);
				}
			}
		}

		public FParticleSpawnSignature OnParticleSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleSpawn, __ReturnBuffer);

					return *(FParticleSpawnSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleSpawn, __InBuffer);
				}
			}
		}

		public FParticleBurstSignature OnParticleBurst
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleBurst, __ReturnBuffer);

					return *(FParticleBurstSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleBurst, __InBuffer);
				}
			}
		}

		public FParticleDeathSignature OnParticleDeath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleDeath, __ReturnBuffer);

					return *(FParticleDeathSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleDeath, __InBuffer);
				}
			}
		}

		public FParticleCollisionSignature OnParticleCollide
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleCollide, __ReturnBuffer);

					return *(FParticleCollisionSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnParticleCollide, __InBuffer);
				}
			}
		}

		public bool bOldPositionValid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOldPositionValid, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOldPositionValid, __InBuffer);
				}
			}
		}

		public FVector OldPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OldPosition, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OldPosition, __InBuffer);
				}
			}
		}

		public FVector PartSysVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PartSysVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PartSysVelocity, __InBuffer);
				}
			}
		}

		public float WarmupTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTime, __InBuffer);
				}
			}
		}

		public float WarmupTickRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WarmupTickRate, __InBuffer);
				}
			}
		}

		public float SecondsBeforeInactive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SecondsBeforeInactive, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SecondsBeforeInactive, __InBuffer);
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

		public int EditorLODLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorLODLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorLODLevel, __InBuffer);
				}
			}
		}

		public int EditorDetailMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorDetailMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorDetailMode, __InBuffer);
				}
			}
		}

		public TArray<UParticleSystemReplay> ReplayClips
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplayClips, __ReturnBuffer);

					return *(TArray<UParticleSystemReplay>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplayClips, __InBuffer);
				}
			}
		}

		public float CustomTimeDilation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomTimeDilation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomTimeDilation, __InBuffer);
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

		public FOnSystemFinished OnSystemFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSystemFinished, __ReturnBuffer);

					return *(FOnSystemFinished*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleSystemComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InFirstSocketName">
		/// The name of the first socket for the trail.
		/// </param>
		/// <param name="InSecondSocketName">
		/// The name of the second socket for the trail.
		/// </param>
		/// <param name="InWidthMode">
		/// How the width value is applied to the trail.
		/// </param>
		/// <param name="InWidth">
		/// The width of the trail.
		/// </param>
		public virtual void SetTrailSourceData(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InFirstSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSecondSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InWidthMode;

				*(float*)(__InBuffer + 17) = InWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTrailSourceData, __InBuffer);
			}
		}

		public virtual void SetTemplate(UParticleSystem NewTemplate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTemplate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTemplate, __InBuffer);
			}
		}

		public virtual void SetMaterialParameter(FName ParameterName, UMaterialInterface Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterialParameter, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewTangentPoint">
		/// The value to set it to
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamTargetTangent(int EmitterIndex, FVector NewTangentPoint, int TargetIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = NewTangentPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 12) = TargetIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamTargetTangent, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewTargetStrength">
		/// The value to set it to
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamTargetStrength(int EmitterIndex, float NewTargetStrength, int TargetIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(float*)(__InBuffer + 4) = NewTargetStrength;

				*(int*)(__InBuffer + 8) = TargetIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamTargetStrength, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewTargetPoint">
		/// The value to set it to
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamTargetPoint(int EmitterIndex, FVector NewTargetPoint, int TargetIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = NewTargetPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 12) = TargetIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamTargetPoint, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewTangentPoint">
		/// The value to set it to
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamSourceTangent(int EmitterIndex, FVector NewTangentPoint, int SourceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = NewTangentPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 12) = SourceIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamSourceTangent, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewSourceStrength">
		/// The value to set it to
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamSourceStrength(int EmitterIndex, float NewSourceStrength, int SourceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(float*)(__InBuffer + 4) = NewSourceStrength;

				*(int*)(__InBuffer + 8) = SourceIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamSourceStrength, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewSourcePoint">
		/// The value to set it to
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to set it on
		/// </param>
		public virtual void SetBeamSourcePoint(int EmitterIndex, FVector NewSourcePoint, int SourceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = NewSourcePoint?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 12) = SourceIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamSourcePoint, __InBuffer);
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to set it on
		/// </param>
		/// <param name="NewEndPoint">
		/// The value to set it to
		/// </param>
		public virtual void SetBeamEndPoint(int EmitterIndex, FVector NewEndPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = NewEndPoint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBeamEndPoint, __InBuffer);
			}
		}

		/// <param name="Parent">
		/// Component to attach to. 
		/// </param>
		/// <param name="SocketName">
		/// Socket on Parent to attach to.
		/// </param>
		/// <param name="LocationType">
		/// Option for how we handle our location when we attach to Parent.
		/// </param>
		/// <see>
		/// bAutoManageAttachment, AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType
		/// </see>
		public virtual void SetAutoAttachParams(USceneComponent Parent, FName SocketName = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset)
		{
			unsafe
			{
				SocketName ??= new FName("None");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)LocationType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoAttachParams, __InBuffer);
			}
		}

		public virtual int GetNumActiveParticles()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumActiveParticles, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInterface GetNamedMaterial(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNamedMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutTangentPoint">
		/// Value of target tangent
		/// </param>
		/// <returns>
		/// true		EmitterIndex and TargetIndex are valid - OutTangentPoint is valid
		/// false		EmitterIndex or TargetIndex is invalid - OutTangentPoint is invalid
		/// </returns>
		public virtual bool GetBeamTargetTangent(int EmitterIndex, int TargetIndex, ref FVector OutTangentPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = TargetIndex;

				*(nint*)(__InBuffer + 8) = OutTangentPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamTargetTangent, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTangentPoint = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutTargetStrength">
		/// Value of target tangent
		/// </param>
		/// <returns>
		/// true		EmitterIndex and TargetIndex are valid - OutTargetStrength is valid
		/// false		EmitterIndex or TargetIndex is invalid - OutTargetStrength is invalid
		/// </returns>
		public virtual bool GetBeamTargetStrength(int EmitterIndex, int TargetIndex, ref float OutTargetStrength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = TargetIndex;

				*(float*)(__InBuffer + 8) = OutTargetStrength;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamTargetStrength, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTargetStrength = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="TargetIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutTargetPoint">
		/// Value of target point
		/// </param>
		/// <returns>
		/// true		EmitterIndex and TargetIndex are valid - OutTargetPoint is valid
		/// false		EmitterIndex or TargetIndex is invalid - OutTargetPoint is invalid
		/// </returns>
		public virtual bool GetBeamTargetPoint(int EmitterIndex, int TargetIndex, ref FVector OutTargetPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = TargetIndex;

				*(nint*)(__InBuffer + 8) = OutTargetPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamTargetPoint, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTargetPoint = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutTangentPoint">
		/// Value of source tangent
		/// </param>
		/// <returns>
		/// true		EmitterIndex and SourceIndex are valid - OutTangentPoint is valid
		/// false		EmitterIndex or SourceIndex is invalid - OutTangentPoint is invalid
		/// </returns>
		public virtual bool GetBeamSourceTangent(int EmitterIndex, int SourceIndex, ref FVector OutTangentPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = SourceIndex;

				*(nint*)(__InBuffer + 8) = OutTangentPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamSourceTangent, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTangentPoint = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutSourceStrength">
		/// Value of source tangent
		/// </param>
		/// <returns>
		/// true		EmitterIndex and SourceIndex are valid - OutSourceStrength is valid
		/// false		EmitterIndex or SourceIndex is invalid - OutSourceStrength is invalid
		/// </returns>
		public virtual bool GetBeamSourceStrength(int EmitterIndex, int SourceIndex, ref float OutSourceStrength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = SourceIndex;

				*(float*)(__InBuffer + 8) = OutSourceStrength;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamSourceStrength, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSourceStrength = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get
		/// </param>
		/// <param name="SourceIndex">
		/// Which beam within the emitter to get
		/// </param>
		/// <param name="OutSourcePoint">
		/// Value of source point
		/// </param>
		/// <returns>
		/// true		EmitterIndex and SourceIndex are valid - OutSourcePoint is valid
		/// false		EmitterIndex or SourceIndex is invalid - OutSourcePoint is invalid
		/// </returns>
		public virtual bool GetBeamSourcePoint(int EmitterIndex, int SourceIndex, ref FVector OutSourcePoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = EmitterIndex;

				*(int*)(__InBuffer + 4) = SourceIndex;

				*(nint*)(__InBuffer + 8) = OutSourcePoint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamSourcePoint, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSourcePoint = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EmitterIndex">
		/// The index of the emitter to get the value of
		/// </param>
		/// <returns>
		/// true		EmitterIndex is valid and End point is set - OutEndPoint is valid
		/// false		EmitterIndex invalid or End point is not set - OutEndPoint is invalid
		/// </returns>
		public virtual bool GetBeamEndPoint(int EmitterIndex, ref FVector OutEndPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = EmitterIndex;

				*(nint*)(__InBuffer + 4) = OutEndPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBeamEndPoint, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutEndPoint = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InEventName">
		/// The name of the event that fired.
		/// </param>
		/// <param name="InEmitterTime">
		/// The emitter time when the event fired.
		/// </param>
		/// <param name="InLocation">
		/// The location of the particle when the event fired.
		/// </param>
		/// <param name="InVelocity">
		/// The velocity of the particle when the event fired.
		/// </param>
		/// <param name="InNormal">
		/// Normal vector of the collision in coordinate system of the returner. Zero=none.
		/// </param>
		public virtual void GenerateParticleEvent(FName InEventName, float InEmitterTime, FVector InLocation, FVector InDirection, FVector InVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InEmitterTime;

				*(nint*)(__InBuffer + 12) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = InDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = InVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __GenerateParticleEvent, __InBuffer);
			}
		}

		public virtual void EndTrails()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndTrails);
			}
		}

		/// <param name="Name">
		/// - The slot name of the material to replace.  If invalid, the material is unchanged and NULL is returned.
		/// </param>
		public virtual UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(FName InName, UMaterialInterface SourceMaterial = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceMaterial?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateNamedDynamicMaterialInstance, __InBuffer, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		/// <param name="InFirstSocketName">
		/// The name of the first socket for the trail.
		/// </param>
		/// <param name="InSecondSocketName">
		/// The name of the second socket for the trail.
		/// </param>
		/// <param name="InWidthMode">
		/// How the width value is applied to the trail.
		/// </param>
		/// <param name="InWidth">
		/// The width of the trail.
		/// </param>
		public virtual void BeginTrails(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InFirstSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSecondSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InWidthMode;

				*(float*)(__InBuffer + 17) = InWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BeginTrails, __InBuffer);
			}
		}

		private static uint __Template = 0;

		private static uint __EmitterMaterials = 0;

		private static uint __SkelMeshComponents = 0;

		private static uint __bResetOnDetach = 0;

		private static uint __bUpdateOnDedicatedServer = 0;

		private static uint __bAllowRecycling = 0;

		private static uint __bAutoManageAttachment = 0;

		private static uint __bAutoAttachWeldSimulatedBodies = 0;

		private static uint __bWarmingUp = 0;

		private static uint __bOverrideLODMethod = 0;

		private static uint __bSkipUpdateDynamicDataDuringTick = 0;

		private static uint __LODMethod = 0;

		private static uint __RequiredSignificance = 0;

		private static uint __InstanceParameters = 0;

		private static uint __OnParticleSpawn = 0;

		private static uint __OnParticleBurst = 0;

		private static uint __OnParticleDeath = 0;

		private static uint __OnParticleCollide = 0;

		private static uint __bOldPositionValid = 0;

		private static uint __OldPosition = 0;

		private static uint __PartSysVelocity = 0;

		private static uint __WarmupTime = 0;

		private static uint __WarmupTickRate = 0;

		private static uint __SecondsBeforeInactive = 0;

		private static uint __MaxTimeBeforeForceUpdateTransform = 0;

		private static uint __EditorLODLevel = 0;

		private static uint __EditorDetailMode = 0;

		private static uint __ReplayClips = 0;

		private static uint __CustomTimeDilation = 0;

		private static uint __AutoAttachParent = 0;

		private static uint __AutoAttachSocketName = 0;

		private static uint __AutoAttachLocationRule = 0;

		private static uint __AutoAttachRotationRule = 0;

		private static uint __AutoAttachScaleRule = 0;

		private static uint __OnSystemFinished = 0;

		private static uint __SetTrailSourceData = 0;

		private static uint __SetTemplate = 0;

		private static uint __SetMaterialParameter = 0;

		private static uint __SetBeamTargetTangent = 0;

		private static uint __SetBeamTargetStrength = 0;

		private static uint __SetBeamTargetPoint = 0;

		private static uint __SetBeamSourceTangent = 0;

		private static uint __SetBeamSourceStrength = 0;

		private static uint __SetBeamSourcePoint = 0;

		private static uint __SetBeamEndPoint = 0;

		private static uint __SetAutoAttachParams = 0;

		private static uint __GetNumActiveParticles = 0;

		private static uint __GetNamedMaterial = 0;

		private static uint __GetBeamTargetTangent = 0;

		private static uint __GetBeamTargetStrength = 0;

		private static uint __GetBeamTargetPoint = 0;

		private static uint __GetBeamSourceTangent = 0;

		private static uint __GetBeamSourceStrength = 0;

		private static uint __GetBeamSourcePoint = 0;

		private static uint __GetBeamEndPoint = 0;

		private static uint __GenerateParticleEvent = 0;

		private static uint __EndTrails = 0;

		private static uint __CreateNamedDynamicMaterialInstance = 0;

		private static uint __BeginTrails = 0;
	}
}