using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorFontParameterValue")]
	public partial class FEditorFontParameterValue : FEditorParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorFontParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorFontParameterValue()
		{
		}

		public static bool operator ==(FEditorFontParameterValue A, FEditorFontParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorFontParameterValue A, FEditorFontParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorFontParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UFont FontValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FontValue, __ReturnBuffer);

					return *(UFont*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FontValue, __InBuffer);
				}
			}
		}

		public int FontPage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FontPage, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FontPage, __InBuffer);
				}
			}
		}

		private static uint __FontValue = 0;

		private static uint __FontPage = 0;

	}
}