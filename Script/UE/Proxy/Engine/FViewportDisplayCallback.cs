using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FViewportDisplayCallback : FRefDelegate
	{
		public FViewportDisplayCallback() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FViewportDisplayCallback() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Bind(UObject InObject, Delegate InDelegate) => FDelegateImplementation.FDelegate_BindImplementation(GarbageCollectionHandle, InObject.GarbageCollectionHandle, InDelegate);

		public bool Execute(ref FText OutText, ref FLinearColor OutColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutColor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute7Implementation(GarbageCollectionHandle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutText = *(FText*)(__OutBuffer);

				OutColor = *(FLinearColor*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public delegate bool Delegate(ref FText OutText, ref FLinearColor OutColor);
	}
}
