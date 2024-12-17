using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakesCore.TakesCoreBlueprintLibrary
{
	public class FOnTakeRecorderTakeNumberChanged : FDelegate<Action<int>>
	{
		public FOnTakeRecorderTakeNumberChanged() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderTakeNumberChanged() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(int TakeNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TakeNumber;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
