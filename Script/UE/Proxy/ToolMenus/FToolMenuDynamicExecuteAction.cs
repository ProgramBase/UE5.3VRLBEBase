using System;
using Script.CoreUObject;
using Script.Library;
using Script.ToolMenus;

namespace Script.ToolMenus
{
	public class FToolMenuDynamicExecuteAction : FDelegate<Action<FToolMenuContext>>
	{
		public FToolMenuDynamicExecuteAction() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FToolMenuDynamicExecuteAction() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
