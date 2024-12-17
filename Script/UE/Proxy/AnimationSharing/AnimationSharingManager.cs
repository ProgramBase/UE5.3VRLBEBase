using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimationSharingManager")]
	public partial class UAnimationSharingManager : UObject, IStaticClass
	{
		public TArray<USkeleton> Skeletons
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Skeletons, __ReturnBuffer);

					return *(TArray<USkeleton>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Skeletons, __InBuffer);
				}
			}
		}

		public TArray<UAnimSharingInstance> PerSkeletonData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerSkeletonData, __ReturnBuffer);

					return *(TArray<UAnimSharingInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerSkeletonData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharing.AnimationSharingManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RegisterActorWithSkeletonBP(AActor InActor, USkeleton SharingSkeleton)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SharingSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterActorWithSkeletonBP, __InBuffer);
			}
		}

		public static UAnimationSharingManager GetAnimationSharingManager(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationSharingManager, __InBuffer, __ReturnBuffer);

				return *(UAnimationSharingManager*)__ReturnBuffer;
			}
		}

		public static bool CreateAnimationSharingManager(UObject WorldContextObject, UAnimationSharingSetup Setup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Setup?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateAnimationSharingManager, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool AnimationSharingEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __AnimationSharingEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Skeletons = 0;

		private static uint __PerSkeletonData = 0;

		private static uint __RegisterActorWithSkeletonBP = 0;

		private static uint __GetAnimationSharingManager = 0;

		private static uint __CreateAnimationSharingManager = 0;

		private static uint __AnimationSharingEnabled = 0;
	}
}