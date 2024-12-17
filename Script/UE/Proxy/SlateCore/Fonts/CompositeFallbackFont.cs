using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.CompositeFallbackFont")]
	public partial class FCompositeFallbackFont : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.CompositeFallbackFont");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCompositeFallbackFont() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCompositeFallbackFont() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCompositeFallbackFont A, FCompositeFallbackFont B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCompositeFallbackFont A, FCompositeFallbackFont B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCompositeFallbackFont;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTypeface Typeface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Typeface, __ReturnBuffer);

					return *(FTypeface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Typeface, __InBuffer);
				}
			}
		}

		public float ScalingFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalingFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalingFactor, __InBuffer);
				}
			}
		}

		private static uint __Typeface = 0;

		private static uint __ScalingFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}