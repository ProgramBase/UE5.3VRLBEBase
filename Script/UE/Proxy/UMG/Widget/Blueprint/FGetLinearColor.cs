using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.Widget
{
	public class FGetLinearColor : FDelegate<Func<FLinearColor>>
	{
		public FGetLinearColor() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetLinearColor() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public FLinearColor Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}
	}
}
