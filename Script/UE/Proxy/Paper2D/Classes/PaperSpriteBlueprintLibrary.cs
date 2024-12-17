using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.SlateCore;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperSpriteBlueprintLibrary")]
	public partial class UPaperSpriteBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperSpriteBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSlateBrush MakeBrushFromSprite(UPaperSprite Sprite, int Width, int Height)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sprite?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBrushFromSprite, __InBuffer, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		private static uint __MakeBrushFromSprite = 0;
	}
}