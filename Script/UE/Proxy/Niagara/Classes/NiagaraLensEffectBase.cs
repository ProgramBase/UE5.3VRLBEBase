using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraLensEffectBase")]
	public partial class ANiagaraLensEffectBase : ANiagaraActor, IStaticClass, ICameraLensEffectInterface
	{
		public FTransform DesiredRelativeTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredRelativeTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredRelativeTransform, __InBuffer);
				}
			}
		}

		public float BaseAuthoredFOV
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseAuthoredFOV, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseAuthoredFOV, __InBuffer);
				}
			}
		}

		public bool bAllowMultipleInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowMultipleInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowMultipleInstances, __InBuffer);
				}
			}
		}

		public bool bResetWhenRetriggered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetWhenRetriggered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetWhenRetriggered, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<AActor>> EmittersToTreatAsSame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmittersToTreatAsSame, __ReturnBuffer);

					return *(TArray<TSubclassOf<AActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmittersToTreatAsSame, __InBuffer);
				}
			}
		}

		public APlayerCameraManager OwningCameraManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningCameraManager, __ReturnBuffer);

					return *(APlayerCameraManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningCameraManager, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraLensEffectBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UFXSystemComponent GetPrimaryParticleComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPrimaryParticleComponent, __ReturnBuffer);

				return *(UFXSystemComponent*)__ReturnBuffer;
			}
		}

		public virtual TArray<UFXSystemComponent> GetParticleComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParticleComponents, __ReturnBuffer);

				return *(TArray<UFXSystemComponent>*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __DesiredRelativeTransform = 0;

		private static uint __BaseAuthoredFOV = 0;

		private static uint __bAllowMultipleInstances = 0;

		private static uint __bResetWhenRetriggered = 0;

		private static uint __EmittersToTreatAsSame = 0;

		private static uint __OwningCameraManager = 0;

		private static uint __GetPrimaryParticleComponent = 0;

		private static uint __GetParticleComponents = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}