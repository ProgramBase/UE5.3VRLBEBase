using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.UMG;

namespace Script.UMG
{
	public class FCustomWidgetNavigationDelegate : FDelegate<Func<EUINavigation, UWidget>>
	{
		public FCustomWidgetNavigationDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FCustomWidgetNavigationDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public UWidget Execute(EUINavigation Navigation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Navigation;

				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}
	}
}
