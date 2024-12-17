using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimSharingInstance")]
	public partial class UAnimSharingInstance : UObject, IStaticClass
	{
		public TArray<AActor> RegisteredActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredActors, __InBuffer);
				}
			}
		}

		public UAnimationSharingStateProcessor StateProcessor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateProcessor, __ReturnBuffer);

					return *(UAnimationSharingStateProcessor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateProcessor, __InBuffer);
				}
			}
		}

		public TArray<UAnimSequence> UsedAnimationSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UsedAnimationSequences, __ReturnBuffer);

					return *(TArray<UAnimSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UsedAnimationSequences, __InBuffer);
				}
			}
		}

		public UEnum StateEnum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateEnum, __ReturnBuffer);

					return *(UEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateEnum, __InBuffer);
				}
			}
		}

		public AActor SharingActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SharingActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SharingActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharing.AnimSharingInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RegisteredActors = 0;

		private static uint __StateProcessor = 0;

		private static uint __UsedAnimationSequences = 0;

		private static uint __StateEnum = 0;

		private static uint __SharingActor = 0;
	}
}