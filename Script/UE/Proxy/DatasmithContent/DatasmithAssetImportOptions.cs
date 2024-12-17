using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithAssetImportOptions")]
	public partial class FDatasmithAssetImportOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithAssetImportOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithAssetImportOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithAssetImportOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithAssetImportOptions A, FDatasmithAssetImportOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithAssetImportOptions A, FDatasmithAssetImportOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithAssetImportOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PackagePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackagePath, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackagePath, __InBuffer);
				}
			}
		}

		private static uint __PackagePath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}