using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.Widget
{
	public class FGetCheckBoxState : FDelegate<Func<ECheckBoxState>>
	{
		public FGetCheckBoxState() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FGetCheckBoxState() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public ECheckBoxState Execute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute1Implementation(GarbageCollectionHandle, __ReturnBuffer);

				return *(ECheckBoxState*)__ReturnBuffer;
			}
		}
	}
}
