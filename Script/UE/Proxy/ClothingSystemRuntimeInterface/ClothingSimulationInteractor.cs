using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor")]
	public partial class UClothingSimulationInteractor : UObject, IStaticClass
	{
		public TMap<FName, UClothingInteractor> ClothingInteractors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingInteractors, __ReturnBuffer);

					return *(TMap<FName, UClothingInteractor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingInteractors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetNumSubsteps(int NumSubsteps = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumSubsteps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumSubsteps, __InBuffer);
			}
		}

		public virtual void SetNumIterations(int NumIterations = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumIterations;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumIterations, __InBuffer);
			}
		}

		public virtual void SetMaxNumIterations(int MaxNumIterations = 10)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MaxNumIterations;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaxNumIterations, __InBuffer);
			}
		}

		public virtual void SetAnimDriveSpringStiffness(float InStiffness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimDriveSpringStiffness, __InBuffer);
			}
		}

		public virtual void PhysicsAssetUpdated()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PhysicsAssetUpdated);
			}
		}

		public virtual float GetSimulationTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSimulationTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual int GetNumSubsteps()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumSubsteps, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumKinematicParticles()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumKinematicParticles, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumIterations()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumIterations, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumDynamicParticles()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumDynamicParticles, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumCloths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumCloths, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UClothingInteractor GetClothingInteractor(FString ClothingAssetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ClothingAssetName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetClothingInteractor, __InBuffer, __ReturnBuffer);

				return *(UClothingInteractor*)__ReturnBuffer;
			}
		}

		public virtual void EnableGravityOverride(FVector InVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableGravityOverride, __InBuffer);
			}
		}

		public virtual void DisableGravityOverride()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DisableGravityOverride);
			}
		}

		public virtual void ClothConfigUpdated()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClothConfigUpdated);
			}
		}

		private static uint __ClothingInteractors = 0;

		private static uint __SetNumSubsteps = 0;

		private static uint __SetNumIterations = 0;

		private static uint __SetMaxNumIterations = 0;

		private static uint __SetAnimDriveSpringStiffness = 0;

		private static uint __PhysicsAssetUpdated = 0;

		private static uint __GetSimulationTime = 0;

		private static uint __GetNumSubsteps = 0;

		private static uint __GetNumKinematicParticles = 0;

		private static uint __GetNumIterations = 0;

		private static uint __GetNumDynamicParticles = 0;

		private static uint __GetNumCloths = 0;

		private static uint __GetClothingInteractor = 0;

		private static uint __EnableGravityOverride = 0;

		private static uint __DisableGravityOverride = 0;

		private static uint __ClothConfigUpdated = 0;
	}
}