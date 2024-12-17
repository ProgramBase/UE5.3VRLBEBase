using Script.CoreUObject;
using Script.UnrealEd;
using Script.Paper2D;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.PaperTileMapPromotionFactory")]
	public partial class UPaperTileMapPromotionFactory : UFactory, IStaticClass
	{
		public UPaperTileMap AssetToRename
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetToRename, __ReturnBuffer);

					return *(UPaperTileMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetToRename, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.PaperTileMapPromotionFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AssetToRename = 0;
	}
}