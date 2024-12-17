using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.VerticalBox")]
	public partial class UVerticalBox : UPanelWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.VerticalBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UVerticalBoxSlot AddChildToVerticalBox(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToVerticalBox, __InBuffer, __ReturnBuffer);

				return *(UVerticalBoxSlot*)__ReturnBuffer;
			}
		}

		private static uint __AddChildToVerticalBox = 0;
	}
}