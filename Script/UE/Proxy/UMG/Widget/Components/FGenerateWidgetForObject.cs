using System;
using Script.CoreUObject;
using Script.Library;
using Script.UMG;

namespace Script.UMG.Widget
{
	public class FGenerateWidgetForObject : FDelegate<Func<UObject, UWidget>>
	{
		public FGenerateWidgetForObject() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGenerateWidgetForObject() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public UWidget Execute(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}
	}
}
