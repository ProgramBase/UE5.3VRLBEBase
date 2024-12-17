using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimSharingTransitionInstance")]
	public partial class UAnimSharingTransitionInstance : UAnimInstance, IStaticClass
	{
		public TWeakObjectPtr<USkeletalMeshComponent> FromComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FromComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeletalMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FromComponent, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USkeletalMeshComponent> ToComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeletalMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToComponent, __InBuffer);
				}
			}
		}

		public float BlendTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendTime, __InBuffer);
				}
			}
		}

		public bool bBlendBool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendBool, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendBool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharing.AnimSharingTransitionInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FromComponent = 0;

		private static uint __ToComponent = 0;

		private static uint __BlendTime = 0;

		private static uint __bBlendBool = 0;
	}
}