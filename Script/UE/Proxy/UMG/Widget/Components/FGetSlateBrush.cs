using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.Widget
{
	public class FGetSlateBrush : FDelegate<Func<FSlateBrush>>
	{
		public FGetSlateBrush() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetSlateBrush() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public FSlateBrush Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}
	}
}
