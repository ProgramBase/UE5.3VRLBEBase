using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.Widget
{
	public class FGetSlateColor : FDelegate<Func<FSlateColor>>
	{
		public FGetSlateColor() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetSlateColor() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public FSlateColor Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(FSlateColor*)__ReturnBuffer;
			}
		}
	}
}
