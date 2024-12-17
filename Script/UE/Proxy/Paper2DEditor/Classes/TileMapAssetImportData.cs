using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.TileMapAssetImportData")]
	public partial class UTileMapAssetImportData : UAssetImportData, IStaticClass
	{
		public TArray<FTileSetImportMapping> TileSetMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TileSetMap, __ReturnBuffer);

					return *(TArray<FTileSetImportMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TileSetMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.TileMapAssetImportData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TileSetMap = 0;
	}
}