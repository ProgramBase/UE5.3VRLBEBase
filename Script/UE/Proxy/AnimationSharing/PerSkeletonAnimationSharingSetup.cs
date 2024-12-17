using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.PerSkeletonAnimationSharingSetup")]
	public partial class FPerSkeletonAnimationSharingSetup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationSharing.PerSkeletonAnimationSharingSetup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerSkeletonAnimationSharingSetup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerSkeletonAnimationSharingSetup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerSkeletonAnimationSharingSetup A, FPerSkeletonAnimationSharingSetup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerSkeletonAnimationSharingSetup A, FPerSkeletonAnimationSharingSetup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerSkeletonAnimationSharingSetup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USkeleton Skeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Skeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Skeleton, __InBuffer);
				}
			}
		}

		public USkeletalMesh SkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimSharingTransitionInstance> BlendAnimBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendAnimBlueprint, __ReturnBuffer);

					return *(TSubclassOf<UAnimSharingTransitionInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendAnimBlueprint, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimSharingAdditiveInstance> AdditiveAnimBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditiveAnimBlueprint, __ReturnBuffer);

					return *(TSubclassOf<UAnimSharingAdditiveInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditiveAnimBlueprint, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimationSharingStateProcessor> StateProcessorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateProcessorClass, __ReturnBuffer);

					return *(TSubclassOf<UAnimationSharingStateProcessor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateProcessorClass, __InBuffer);
				}
			}
		}

		public TArray<FAnimationStateEntry> AnimationStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimationStates, __ReturnBuffer);

					return *(TArray<FAnimationStateEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimationStates, __InBuffer);
				}
			}
		}

		private static uint __Skeleton = 0;

		private static uint __SkeletalMesh = 0;

		private static uint __BlendAnimBlueprint = 0;

		private static uint __AdditiveAnimBlueprint = 0;

		private static uint __StateProcessorClass = 0;

		private static uint __AnimationStates = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}