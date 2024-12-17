using Script.CoreUObject;
using Script.Library;
using Script.Paper2D;
using Script.Engine;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.TileSetImportMapping")]
	public partial class FTileSetImportMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2DEditor.TileSetImportMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTileSetImportMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTileSetImportMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTileSetImportMapping A, FTileSetImportMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTileSetImportMapping A, FTileSetImportMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTileSetImportMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString SourceName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceName, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UPaperTileSet> ImportedTileSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportedTileSet, __ReturnBuffer);

					return *(TWeakObjectPtr<UPaperTileSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportedTileSet, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UTexture> ImportedTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportedTexture, __ReturnBuffer);

					return *(TWeakObjectPtr<UTexture>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportedTexture, __InBuffer);
				}
			}
		}

		private static uint __SourceName = 0;

		private static uint __ImportedTileSet = 0;

		private static uint __ImportedTexture = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}