using System;
using Script.CoreUObject;
using Script.Library;
using Script.UMG;

namespace Script.UMG.Widget
{
	public class FGetSlateVisibility : FDelegate<Func<ESlateVisibility>>
	{
		public FGetSlateVisibility() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetSlateVisibility() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public ESlateVisibility Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(ESlateVisibility*)__ReturnBuffer;
			}
		}
	}
}
