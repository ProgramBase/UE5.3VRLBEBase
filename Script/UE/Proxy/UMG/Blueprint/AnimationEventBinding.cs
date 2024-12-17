using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.AnimationEventBinding")]
	public partial class FAnimationEventBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.AnimationEventBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationEventBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationEventBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationEventBinding A, FAnimationEventBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationEventBinding A, FAnimationEventBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationEventBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UWidgetAnimation Animation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Animation, __ReturnBuffer);

					return *(UWidgetAnimation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Animation, __InBuffer);
				}
			}
		}

		public FWidgetAnimationDynamicEvent Delegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Delegate, __ReturnBuffer);

					return *(FWidgetAnimationDynamicEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Delegate, __InBuffer);
				}
			}
		}

		public EWidgetAnimationEvent AnimationEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimationEvent, __ReturnBuffer);

					return *(EWidgetAnimationEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimationEvent, __InBuffer);
				}
			}
		}

		public FName UserTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserTag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserTag, __InBuffer);
				}
			}
		}

		private static uint __Animation = 0;

		private static uint __Delegate = 0;

		private static uint __AnimationEvent = 0;

		private static uint __UserTag = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}