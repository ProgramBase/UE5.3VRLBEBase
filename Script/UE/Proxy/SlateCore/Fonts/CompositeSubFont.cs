using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.CompositeSubFont")]
	public partial class FCompositeSubFont : FCompositeFallbackFont, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.CompositeSubFont");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCompositeSubFont()
		{
		}

		public static bool operator ==(FCompositeSubFont A, FCompositeSubFont B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCompositeSubFont A, FCompositeSubFont B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCompositeSubFont;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FInt32Range> CharacterRanges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CharacterRanges, __ReturnBuffer);

					return *(TArray<FInt32Range>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CharacterRanges, __InBuffer);
				}
			}
		}

		public FString Cultures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Cultures, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Cultures, __InBuffer);
				}
			}
		}

		public FName EditorName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorName, __InBuffer);
				}
			}
		}

		private static uint __CharacterRanges = 0;

		private static uint __Cultures = 0;

		private static uint __EditorName = 0;

	}
}