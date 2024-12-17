using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.Typeface")]
	public partial class FTypeface : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.Typeface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypeface() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypeface() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypeface A, FTypeface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypeface A, FTypeface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypeface;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTypefaceEntry> Fonts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Fonts, __ReturnBuffer);

					return *(TArray<FTypefaceEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Fonts, __InBuffer);
				}
			}
		}

		private static uint __Fonts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}