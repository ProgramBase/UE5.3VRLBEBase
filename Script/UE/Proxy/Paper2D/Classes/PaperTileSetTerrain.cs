using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperTileSetTerrain")]
	public partial class FPaperTileSetTerrain : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.PaperTileSetTerrain");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaperTileSetTerrain() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaperTileSetTerrain() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaperTileSetTerrain A, FPaperTileSetTerrain B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaperTileSetTerrain A, FPaperTileSetTerrain B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaperTileSetTerrain;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString TerrainName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TerrainName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TerrainName, __InBuffer);
				}
			}
		}

		public int CenterTileIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CenterTileIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CenterTileIndex, __InBuffer);
				}
			}
		}

		private static uint __TerrainName = 0;

		private static uint __CenterTileIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}