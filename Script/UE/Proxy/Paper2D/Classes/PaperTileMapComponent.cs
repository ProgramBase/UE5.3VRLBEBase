using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperTileMapComponent")]
	public partial class UPaperTileMapComponent : UMeshComponent, IStaticClass
	{
		public FLinearColor TileMapColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TileMapColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TileMapColor, __InBuffer);
				}
			}
		}

		public int UseSingleLayerIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UseSingleLayerIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UseSingleLayerIndex, __InBuffer);
				}
			}
		}

		public bool bUseSingleLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSingleLayer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSingleLayer, __InBuffer);
				}
			}
		}

		public UPaperTileMap TileMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TileMap, __ReturnBuffer);

					return *(UPaperTileMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TileMap, __InBuffer);
				}
			}
		}

		public bool bShowPerTileGridWhenSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerTileGridWhenSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerTileGridWhenSelected, __InBuffer);
				}
			}
		}

		public bool bShowPerLayerGridWhenSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerLayerGridWhenSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerLayerGridWhenSelected, __InBuffer);
				}
			}
		}

		public bool bShowOutlineWhenUnselected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutlineWhenUnselected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutlineWhenUnselected, __InBuffer);
				}
			}
		}

		public bool bShowPerTileGridWhenUnselected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerTileGridWhenUnselected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerTileGridWhenUnselected, __InBuffer);
				}
			}
		}

		public bool bShowPerLayerGridWhenUnselected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerLayerGridWhenUnselected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPerLayerGridWhenUnselected, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperTileMapComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTileMapColor(FLinearColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTileMapColor, __InBuffer);
			}
		}

		public virtual bool SetTileMap(UPaperTileMap NewTileMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTileMap?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTileMap, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetTile(int X, int Y, int Layer, FPaperTileInfo NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = X;

				*(int*)(__InBuffer + 4) = Y;

				*(int*)(__InBuffer + 8) = Layer;

				*(nint*)(__InBuffer + 12) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTile, __InBuffer);
			}
		}

		public virtual void SetLayerColor(FLinearColor NewColor, int Layer = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Layer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayerColor, __InBuffer);
			}
		}

		public virtual void SetLayerCollision(int Layer = 0, bool bHasCollision = true, bool bOverrideThickness = true, float CustomThickness = 50.000000f, bool bOverrideOffset = false, float CustomOffset = 0.000000f, bool bRebuildCollision = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = Layer;

				*(bool*)(__InBuffer + 4) = bHasCollision;

				*(bool*)(__InBuffer + 5) = bOverrideThickness;

				*(float*)(__InBuffer + 6) = CustomThickness;

				*(bool*)(__InBuffer + 10) = bOverrideOffset;

				*(float*)(__InBuffer + 11) = CustomOffset;

				*(bool*)(__InBuffer + 15) = bRebuildCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayerCollision, __InBuffer);
			}
		}

		public virtual void SetDefaultCollisionThickness(float Thickness, bool bRebuildCollision = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Thickness;

				*(bool*)(__InBuffer + 4) = bRebuildCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCollisionThickness, __InBuffer);
			}
		}

		public virtual void ResizeMap(int NewWidthInTiles, int NewHeightInTiles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = NewWidthInTiles;

				*(int*)(__InBuffer + 4) = NewHeightInTiles;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResizeMap, __InBuffer);
			}
		}

		public virtual void RebuildCollision()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RebuildCollision);
			}
		}

		public virtual bool OwnsTileMap()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __OwnsTileMap, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void MakeTileMapEditable()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MakeTileMapEditable);
			}
		}

		public virtual void GetTilePolygon(int TileX, int TileY, ref TArray<FVector> Points, int LayerIndex, bool bWorldSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(int*)(__InBuffer) = TileX;

				*(int*)(__InBuffer + 4) = TileY;

				*(nint*)(__InBuffer + 8) = Points?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = LayerIndex;

				*(bool*)(__InBuffer + 20) = bWorldSpace;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTilePolygon, __InBuffer, __OutBuffer);

				Points = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public virtual FLinearColor GetTileMapColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTileMapColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTileCornerPosition(int TileX, int TileY, int LayerIndex = 0, bool bWorldSpace = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = TileX;

				*(int*)(__InBuffer + 4) = TileY;

				*(int*)(__InBuffer + 8) = LayerIndex;

				*(bool*)(__InBuffer + 12) = bWorldSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTileCornerPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTileCenterPosition(int TileX, int TileY, int LayerIndex = 0, bool bWorldSpace = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = TileX;

				*(int*)(__InBuffer + 4) = TileY;

				*(int*)(__InBuffer + 8) = LayerIndex;

				*(bool*)(__InBuffer + 12) = bWorldSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTileCenterPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FPaperTileInfo GetTile(int X, int Y, int Layer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = X;

				*(int*)(__InBuffer + 4) = Y;

				*(int*)(__InBuffer + 8) = Layer;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTile, __InBuffer, __ReturnBuffer);

				return *(FPaperTileInfo*)__ReturnBuffer;
			}
		}

		public virtual void GetMapSize(ref int MapWidth, ref int MapHeight, ref int NumLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = MapWidth;

				*(int*)(__InBuffer + 4) = MapHeight;

				*(int*)(__InBuffer + 8) = NumLayers;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMapSize, __InBuffer, __OutBuffer);

				MapWidth = *(int*)(__OutBuffer);

				MapHeight = *(int*)(__OutBuffer + 4);

				NumLayers = *(int*)(__OutBuffer + 8);

			}
		}

		public virtual FLinearColor GetLayerColor(int Layer = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Layer;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLayerColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		/// <param name="MapWidth">
		/// Width of the map (in tiles)
		/// </param>
		/// <param name="MapHeight">
		/// Height of the map (in tiles)
		/// </param>
		/// <param name="TileWidth">
		/// Width of one tile (in pixels)
		/// </param>
		/// <param name="TileHeight">
		/// Height of one tile (in pixels)
		/// </param>
		/// <param name="bCreateLayer">
		/// Should an empty layer be created?
		/// </param>
		public virtual void CreateNewTileMap(int MapWidth = 4, int MapHeight = 4, int TileWidth = 32, int TileHeight = 32, float PixelsPerUnrealUnit = 1.000000f, bool bCreateLayer = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(int*)(__InBuffer) = MapWidth;

				*(int*)(__InBuffer + 4) = MapHeight;

				*(int*)(__InBuffer + 8) = TileWidth;

				*(int*)(__InBuffer + 12) = TileHeight;

				*(float*)(__InBuffer + 16) = PixelsPerUnrealUnit;

				*(bool*)(__InBuffer + 20) = bCreateLayer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateNewTileMap, __InBuffer);
			}
		}

		public virtual UPaperTileLayer AddNewLayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AddNewLayer, __ReturnBuffer);

				return *(UPaperTileLayer*)__ReturnBuffer;
			}
		}

		private static uint __TileMapColor = 0;

		private static uint __UseSingleLayerIndex = 0;

		private static uint __bUseSingleLayer = 0;

		private static uint __TileMap = 0;

		private static uint __bShowPerTileGridWhenSelected = 0;

		private static uint __bShowPerLayerGridWhenSelected = 0;

		private static uint __bShowOutlineWhenUnselected = 0;

		private static uint __bShowPerTileGridWhenUnselected = 0;

		private static uint __bShowPerLayerGridWhenUnselected = 0;

		private static uint __SetTileMapColor = 0;

		private static uint __SetTileMap = 0;

		private static uint __SetTile = 0;

		private static uint __SetLayerColor = 0;

		private static uint __SetLayerCollision = 0;

		private static uint __SetDefaultCollisionThickness = 0;

		private static uint __ResizeMap = 0;

		private static uint __RebuildCollision = 0;

		private static uint __OwnsTileMap = 0;

		private static uint __MakeTileMapEditable = 0;

		private static uint __GetTilePolygon = 0;

		private static uint __GetTileMapColor = 0;

		private static uint __GetTileCornerPosition = 0;

		private static uint __GetTileCenterPosition = 0;

		private static uint __GetTile = 0;

		private static uint __GetMapSize = 0;

		private static uint __GetLayerColor = 0;

		private static uint __CreateNewTileMap = 0;

		private static uint __AddNewLayer = 0;
	}
}