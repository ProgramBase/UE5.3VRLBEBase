using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.UMG;

namespace Script.UMG.Widget
{
	public class FOnPointerEvent : FDelegate<Func<FGeometry, FPointerEvent, FEventReply>>
	{
		public FOnPointerEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnPointerEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public FEventReply Execute(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}
	}
}
