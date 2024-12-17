using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.RecastNavMeshTileGenerationDebug")]
	public partial class FRecastNavMeshTileGenerationDebug : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NavigationSystem.RecastNavMeshTileGenerationDebug");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRecastNavMeshTileGenerationDebug() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRecastNavMeshTileGenerationDebug() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRecastNavMeshTileGenerationDebug A, FRecastNavMeshTileGenerationDebug B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRecastNavMeshTileGenerationDebug A, FRecastNavMeshTileGenerationDebug B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRecastNavMeshTileGenerationDebug;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __InBuffer);
				}
			}
		}

		public FIntVector TileCoordinate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TileCoordinate, __ReturnBuffer);

					return *(FIntVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TileCoordinate, __InBuffer);
				}
			}
		}

		public bool bGenerateDebugTileOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bGenerateDebugTileOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bGenerateDebugTileOnly, __InBuffer);
				}
			}
		}

		public bool bCollisionGeometry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCollisionGeometry, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCollisionGeometry, __InBuffer);
				}
			}
		}

		public EHeightFieldRenderMode HeightFieldRenderMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HeightFieldRenderMode, __ReturnBuffer);

					return *(EHeightFieldRenderMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HeightFieldRenderMode, __InBuffer);
				}
			}
		}

		public bool bHeightfieldFromRasterization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldFromRasterization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldFromRasterization, __InBuffer);
				}
			}
		}

		public bool bHeightfieldPostInclusionBoundsFiltering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldPostInclusionBoundsFiltering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldPostInclusionBoundsFiltering, __InBuffer);
				}
			}
		}

		public bool bHeightfieldPostHeightFiltering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldPostHeightFiltering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldPostHeightFiltering, __InBuffer);
				}
			}
		}

		public bool bHeightfieldBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHeightfieldBounds, __InBuffer);
				}
			}
		}

		public bool bCompactHeightfield
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfield, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfield, __InBuffer);
				}
			}
		}

		public bool bCompactHeightfieldEroded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldEroded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldEroded, __InBuffer);
				}
			}
		}

		public bool bCompactHeightfieldRegions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldRegions, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldRegions, __InBuffer);
				}
			}
		}

		public bool bCompactHeightfieldDistances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldDistances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCompactHeightfieldDistances, __InBuffer);
				}
			}
		}

		public bool bTileCacheLayerAreas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheLayerAreas, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheLayerAreas, __InBuffer);
				}
			}
		}

		public bool bTileCacheLayerRegions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheLayerRegions, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheLayerRegions, __InBuffer);
				}
			}
		}

		public bool bTileCacheContours
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheContours, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheContours, __InBuffer);
				}
			}
		}

		public bool bTileCachePolyMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTileCachePolyMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTileCachePolyMesh, __InBuffer);
				}
			}
		}

		public bool bTileCacheDetailMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheDetailMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTileCacheDetailMesh, __InBuffer);
				}
			}
		}

		private static uint __bEnabled = 0;

		private static uint __TileCoordinate = 0;

		private static uint __bGenerateDebugTileOnly = 0;

		private static uint __bCollisionGeometry = 0;

		private static uint __HeightFieldRenderMode = 0;

		private static uint __bHeightfieldFromRasterization = 0;

		private static uint __bHeightfieldPostInclusionBoundsFiltering = 0;

		private static uint __bHeightfieldPostHeightFiltering = 0;

		private static uint __bHeightfieldBounds = 0;

		private static uint __bCompactHeightfield = 0;

		private static uint __bCompactHeightfieldEroded = 0;

		private static uint __bCompactHeightfieldRegions = 0;

		private static uint __bCompactHeightfieldDistances = 0;

		private static uint __bTileCacheLayerAreas = 0;

		private static uint __bTileCacheLayerRegions = 0;

		private static uint __bTileCacheContours = 0;

		private static uint __bTileCachePolyMesh = 0;

		private static uint __bTileCacheDetailMesh = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}