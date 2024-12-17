using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimCurveMetadataEditorClipboard")]
	public partial class FAnimCurveMetadataEditorClipboard : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Persona.AnimCurveMetadataEditorClipboard");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimCurveMetadataEditorClipboard() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimCurveMetadataEditorClipboard() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimCurveMetadataEditorClipboard A, FAnimCurveMetadataEditorClipboard B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimCurveMetadataEditorClipboard A, FAnimCurveMetadataEditorClipboard B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimCurveMetadataEditorClipboard;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAnimCurveMetadataEditorClipboardEntry> Entries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __ReturnBuffer);

					return *(TArray<FAnimCurveMetadataEditorClipboardEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __InBuffer);
				}
			}
		}

		private static uint __Entries = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}