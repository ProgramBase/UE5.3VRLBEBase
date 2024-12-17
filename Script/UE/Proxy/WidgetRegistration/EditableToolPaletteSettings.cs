using Script.CoreUObject;
using Script.Library;

namespace Script.WidgetRegistration
{
	[PathName("/Script/WidgetRegistration.EditableToolPaletteSettings")]
	public partial class FEditableToolPaletteSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WidgetRegistration.EditableToolPaletteSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditableToolPaletteSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditableToolPaletteSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditableToolPaletteSettings A, FEditableToolPaletteSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditableToolPaletteSettings A, FEditableToolPaletteSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditableToolPaletteSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FString> PaletteCommandNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaletteCommandNames, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaletteCommandNames, __InBuffer);
				}
			}
		}

		private static uint __PaletteCommandNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}