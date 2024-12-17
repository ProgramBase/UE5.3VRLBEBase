using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsAsset")]
	public partial class UPhysicsAsset : UObject, IStaticClass, IInterface_PreviewMeshProvider
	{
		public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewSkeletalMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewSkeletalMesh, __InBuffer);
				}
			}
		}

		public TArray<FName> PhysicalAnimationProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationProfiles, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationProfiles, __InBuffer);
				}
			}
		}

		public TArray<FName> ConstraintProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintProfiles, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintProfiles, __InBuffer);
				}
			}
		}

		public FName CurrentPhysicalAnimationProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPhysicalAnimationProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPhysicalAnimationProfileName, __InBuffer);
				}
			}
		}

		public FName CurrentConstraintProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentConstraintProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentConstraintProfileName, __InBuffer);
				}
			}
		}

		public TArray<int> BoundsBodies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundsBodies, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundsBodies, __InBuffer);
				}
			}
		}

		public TArray<USkeletalBodySetup> SkeletalBodySetups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalBodySetups, __ReturnBuffer);

					return *(TArray<USkeletalBodySetup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalBodySetups, __InBuffer);
				}
			}
		}

		public TArray<UPhysicsConstraintTemplate> ConstraintSetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintSetup, __ReturnBuffer);

					return *(TArray<UPhysicsConstraintTemplate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintSetup, __InBuffer);
				}
			}
		}

		public FPhysicsAssetSolverSettings SolverSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SolverSettings, __ReturnBuffer);

					return *(FPhysicsAssetSolverSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SolverSettings, __InBuffer);
				}
			}
		}

		public FSolverIterations SolverIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SolverIterations, __ReturnBuffer);

					return *(FSolverIterations*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SolverIterations, __InBuffer);
				}
			}
		}

		public EPhysicsAssetSolverType SolverType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SolverType, __ReturnBuffer);

					return *(EPhysicsAssetSolverType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SolverType, __InBuffer);
				}
			}
		}

		public bool bNotForDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotForDedicatedServer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotForDedicatedServer, __InBuffer);
				}
			}
		}

		public UThumbnailInfo ThumbnailInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __ReturnBuffer);

					return *(UThumbnailInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

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

		/// <param name="IncludesTerminated">
		/// whether or not to return terminated constraints
		/// </param>
		/// <param name="OutConstraints">
		/// returned list of constraints matching the parameters
		/// </param>
		public virtual void GetConstraints(bool bIncludesTerminated, ref TArray<FConstraintInstanceAccessor> OutConstraints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bIncludesTerminated;

				*(nint*)(__InBuffer + 1) = OutConstraints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetConstraints, __InBuffer, __OutBuffer);

				OutConstraints = *(TArray<FConstraintInstanceAccessor>*)(__OutBuffer);

			}
		}

		/// <param name="ConstraintName">
		/// name of the constraint
		/// </param>
		/// <returns>
		/// ConstraintInstance accessor to the constraint data
		/// </returns>
		public virtual FConstraintInstanceAccessor GetConstraintByName(FName ConstraintName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ConstraintName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetConstraintByName, __InBuffer, __ReturnBuffer);

				return *(FConstraintInstanceAccessor*)__ReturnBuffer;
			}
		}

		/// <param name="Bone1Name">
		/// name of the first bone in the joint
		/// </param>
		/// <param name="Bone2Name">
		/// name of the second bone in the joint
		/// </param>
		/// <returns>
		/// ConstraintInstance accessor to the constraint data
		/// </returns>
		public virtual FConstraintInstanceAccessor GetConstraintByBoneNames(FName Bone1Name, FName Bone2Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Bone1Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Bone2Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetConstraintByBoneNames, __InBuffer, __ReturnBuffer);

				return *(FConstraintInstanceAccessor*)__ReturnBuffer;
			}
		}

		private static uint __PreviewSkeletalMesh = 0;

		private static uint __PhysicalAnimationProfiles = 0;

		private static uint __ConstraintProfiles = 0;

		private static uint __CurrentPhysicalAnimationProfileName = 0;

		private static uint __CurrentConstraintProfileName = 0;

		private static uint __BoundsBodies = 0;

		private static uint __SkeletalBodySetups = 0;

		private static uint __ConstraintSetup = 0;

		private static uint __SolverSettings = 0;

		private static uint __SolverIterations = 0;

		private static uint __SolverType = 0;

		private static uint __bNotForDedicatedServer = 0;

		private static uint __ThumbnailInfo = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __GetConstraints = 0;

		private static uint __GetConstraintByName = 0;

		private static uint __GetConstraintByBoneNames = 0;
	}
}