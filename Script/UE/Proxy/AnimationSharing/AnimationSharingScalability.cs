using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimationSharingScalability")]
	public partial class FAnimationSharingScalability : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationSharing.AnimationSharingScalability");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationSharingScalability() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationSharingScalability() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationSharingScalability A, FAnimationSharingScalability B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationSharingScalability A, FAnimationSharingScalability B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationSharingScalability;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPerPlatformBool UseBlendTransitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UseBlendTransitions, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UseBlendTransitions, __InBuffer);
				}
			}
		}

		public FPerPlatformFloat BlendSignificanceValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendSignificanceValue, __ReturnBuffer);

					return *(FPerPlatformFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendSignificanceValue, __InBuffer);
				}
			}
		}

		public FPerPlatformInt MaximumNumberConcurrentBlends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaximumNumberConcurrentBlends, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaximumNumberConcurrentBlends, __InBuffer);
				}
			}
		}

		public FPerPlatformFloat TickSignificanceValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TickSignificanceValue, __ReturnBuffer);

					return *(FPerPlatformFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TickSignificanceValue, __InBuffer);
				}
			}
		}

		private static uint __UseBlendTransitions = 0;

		private static uint __BlendSignificanceValue = 0;

		private static uint __MaximumNumberConcurrentBlends = 0;

		private static uint __TickSignificanceValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}