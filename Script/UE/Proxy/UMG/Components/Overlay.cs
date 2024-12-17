using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.Overlay")]
	public partial class UOverlay : UPanelWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.Overlay");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool ReplaceOverlayChildAt(int Index, UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReplaceOverlayChildAt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UOverlaySlot AddChildToOverlay(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToOverlay, __InBuffer, __ReturnBuffer);

				return *(UOverlaySlot*)__ReturnBuffer;
			}
		}

		private static uint __ReplaceOverlayChildAt = 0;

		private static uint __AddChildToOverlay = 0;
	}
}