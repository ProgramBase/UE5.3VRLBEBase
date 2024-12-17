using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.CompositeFont")]
	public partial class FCompositeFont : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.CompositeFont");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCompositeFont() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCompositeFont() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCompositeFont A, FCompositeFont B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCompositeFont A, FCompositeFont B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCompositeFont;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTypeface DefaultTypeface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTypeface, __ReturnBuffer);

					return *(FTypeface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTypeface, __InBuffer);
				}
			}
		}

		public FCompositeFallbackFont FallbackTypeface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FallbackTypeface, __ReturnBuffer);

					return *(FCompositeFallbackFont*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FallbackTypeface, __InBuffer);
				}
			}
		}

		public TArray<FCompositeSubFont> SubTypefaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubTypefaces, __ReturnBuffer);

					return *(TArray<FCompositeSubFont>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubTypefaces, __InBuffer);
				}
			}
		}

		private static uint __DefaultTypeface = 0;

		private static uint __FallbackTypeface = 0;

		private static uint __SubTypefaces = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}