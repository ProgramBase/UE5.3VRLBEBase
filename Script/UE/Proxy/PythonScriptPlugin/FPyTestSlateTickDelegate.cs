using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	public class FPyTestSlateTickDelegate : FDelegate<Action<float>>
	{
		public FPyTestSlateTickDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FPyTestSlateTickDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(float InDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDeltaTime;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
