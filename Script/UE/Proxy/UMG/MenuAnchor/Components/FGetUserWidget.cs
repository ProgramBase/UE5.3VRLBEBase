using System;
using Script.CoreUObject;
using Script.Library;
using Script.UMG;

namespace Script.UMG.MenuAnchor
{
	public class FGetUserWidget : FDelegate<Func<UUserWidget>>
	{
		public FGetUserWidget() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetUserWidget() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public UUserWidget Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}
	}
}
