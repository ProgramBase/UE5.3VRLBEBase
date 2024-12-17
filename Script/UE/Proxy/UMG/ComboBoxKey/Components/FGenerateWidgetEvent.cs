using System;
using Script.CoreUObject;
using Script.Library;
using Script.UMG;

namespace Script.UMG.ComboBoxKey
{
	public class FGenerateWidgetEvent : FDelegate<Func<FName, UWidget>>
	{
		public FGenerateWidgetEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGenerateWidgetEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public UWidget Execute(FName Item)
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
