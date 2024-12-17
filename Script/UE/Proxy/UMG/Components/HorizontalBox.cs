using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.HorizontalBox")]
	public partial class UHorizontalBox : UPanelWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.HorizontalBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UHorizontalBoxSlot AddChildToHorizontalBox(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToHorizontalBox, __InBuffer, __ReturnBuffer);

				return *(UHorizontalBoxSlot*)__ReturnBuffer;
			}
		}

		private static uint __AddChildToHorizontalBox = 0;
	}
}