using System;
using Script.CoreUObject;
using Script.Library;
using Script.UMG;

namespace Script.UMG.Widget
{
	public class FGetWidget : FDelegate<Func<UWidget>>
	{
		public FGetWidget() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetWidget() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public UWidget Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}
	}
}
