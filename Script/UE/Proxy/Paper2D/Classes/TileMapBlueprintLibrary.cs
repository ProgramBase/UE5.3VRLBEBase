using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.TileMapBlueprintLibrary")]
	public partial class UTileMapBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.TileMapBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FPaperTileInfo MakeTile(int TileIndex, UPaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = TileIndex;

				*(nint*)(__InBuffer + 4) = TileSet?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bFlipH;

				*(bool*)(__InBuffer + 13) = bFlipV;

				*(bool*)(__InBuffer + 14) = bFlipD;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeTile, __InBuffer, __ReturnBuffer);

				return *(FPaperTileInfo*)__ReturnBuffer;
			}
		}

		public static FName GetTileUserData(FPaperTileInfo Tile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tile?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTileUserData, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static FTransform GetTileTransform(FPaperTileInfo Tile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tile?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTileTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static void BreakTile(FPaperTileInfo Tile, ref int TileIndex, ref UPaperTileSet TileSet, ref bool bFlipH, ref bool bFlipV, ref bool bFlipD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[23];

				*(nint*)(__InBuffer) = Tile?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = TileIndex;

				*(nint*)(__InBuffer + 12) = TileSet?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bFlipH;

				*(bool*)(__InBuffer + 21) = bFlipV;

				*(bool*)(__InBuffer + 22) = bFlipD;

				var __OutBuffer = stackalloc byte[15];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakTile, __InBuffer, __OutBuffer);

				TileIndex = *(int*)(__OutBuffer);

				TileSet = *(UPaperTileSet*)(__OutBuffer + 4);

				bFlipH = *(bool*)(__OutBuffer + 12);

				bFlipV = *(bool*)(__OutBuffer + 13);

				bFlipD = *(bool*)(__OutBuffer + 14);

			}
		}

		private static uint __MakeTile = 0;

		private static uint __GetTileUserData = 0;

		private static uint __GetTileTransform = 0;

		private static uint __BreakTile = 0;
	}
}