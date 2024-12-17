using System;
using Script.CoreUObject;
using Script.Library;
using Script.ToolMenus;

namespace Script.ToolMenus
{
	public class FToolMenuDynamicIsActionButtonVisible : FDelegate<Func<FToolMenuContext, bool>>
	{
		public FToolMenuDynamicIsActionButtonVisible() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FToolMenuDynamicIsActionButtonVisible() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public bool Execute(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}
	}
}
