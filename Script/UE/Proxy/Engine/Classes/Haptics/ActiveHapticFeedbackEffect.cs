using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActiveHapticFeedbackEffect")]
	public partial class FActiveHapticFeedbackEffect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActiveHapticFeedbackEffect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveHapticFeedbackEffect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveHapticFeedbackEffect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveHapticFeedbackEffect A, FActiveHapticFeedbackEffect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveHapticFeedbackEffect A, FActiveHapticFeedbackEffect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveHapticFeedbackEffect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UHapticFeedbackEffect_Base HapticEffect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HapticEffect, __ReturnBuffer);

					return *(UHapticFeedbackEffect_Base*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HapticEffect, __InBuffer);
				}
			}
		}

		private static uint __HapticEffect = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}