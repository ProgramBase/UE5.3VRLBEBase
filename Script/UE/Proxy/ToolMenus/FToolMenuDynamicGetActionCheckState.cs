using System;
using Script.CoreUObject;
using Script.Library;
using Script.ToolMenus;
using Script.SlateCore;

namespace Script.ToolMenus
{
	public class FToolMenuDynamicGetActionCheckState : FDelegate<Func<FToolMenuContext, ECheckBoxState>>
	{
		public FToolMenuDynamicGetActionCheckState() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FToolMenuDynamicGetActionCheckState() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public ECheckBoxState Execute(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(ECheckBoxState*)__ReturnBuffer;
			}
		}
	}
}
