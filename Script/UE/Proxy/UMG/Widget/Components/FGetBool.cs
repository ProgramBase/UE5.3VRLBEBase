using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.Widget
{
	public class FGetBool : FDelegate<Func<bool>>
	{
		public FGetBool() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetBool() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public bool Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}
	}
}
