using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimCurveMetadataEditorClipboardEntry")]
	public partial class FAnimCurveMetadataEditorClipboardEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Persona.AnimCurveMetadataEditorClipboardEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimCurveMetadataEditorClipboardEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimCurveMetadataEditorClipboardEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimCurveMetadataEditorClipboardEntry A, FAnimCurveMetadataEditorClipboardEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimCurveMetadataEditorClipboardEntry A, FAnimCurveMetadataEditorClipboardEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimCurveMetadataEditorClipboardEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CurveName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveName, __InBuffer);
				}
			}
		}

		public FCurveMetaData MetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __ReturnBuffer);

					return *(FCurveMetaData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __InBuffer);
				}
			}
		}

		private static uint __CurveName = 0;

		private static uint __MetaData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}