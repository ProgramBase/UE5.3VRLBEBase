using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithStaticMeshImportData")]
	public partial class UDatasmithStaticMeshImportData : UDatasmithAssetImportData, IStaticClass
	{
		public FDatasmithStaticMeshImportOptions ImportOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportOptions, __ReturnBuffer);

					return *(FDatasmithStaticMeshImportOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithStaticMeshImportData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ImportOptions = 0;
	}
}