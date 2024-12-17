using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.Widget
{
	public class FGetFloat : FDelegate<Func<float>>
	{
		public FGetFloat() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetFloat() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public float Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FDelegateImplementation.FDelegate_PrimitiveExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}
	}
}
