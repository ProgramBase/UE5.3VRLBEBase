using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ContentWidget")]
	public partial class UContentWidget : UPanelWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ContentWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UPanelSlot SetContent(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetContent, __InBuffer, __ReturnBuffer);

				return *(UPanelSlot*)__ReturnBuffer;
			}
		}

		public virtual UPanelSlot GetContentSlot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetContentSlot, __ReturnBuffer);

				return *(UPanelSlot*)__ReturnBuffer;
			}
		}

		public virtual UWidget GetContent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetContent, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}

		private static uint __SetContent = 0;

		private static uint __GetContentSlot = 0;

		private static uint __GetContent = 0;
	}
}