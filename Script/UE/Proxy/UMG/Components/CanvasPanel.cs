using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.CanvasPanel")]
	public partial class UCanvasPanel : UPanelWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.CanvasPanel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UCanvasPanelSlot AddChildToCanvas(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToCanvas, __InBuffer, __ReturnBuffer);

				return *(UCanvasPanelSlot*)__ReturnBuffer;
			}
		}

		private static uint __AddChildToCanvas = 0;
	}
}