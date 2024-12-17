using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	public class FGetHighlightTextDelegate : FDelegate<Func<FText>>
	{
		public FGetHighlightTextDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetHighlightTextDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
