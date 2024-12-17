using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.Widget
{
	public class FGetText : FDelegate<Func<FText>>
	{
		public FGetText() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetText() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public FText Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}
	}
}
