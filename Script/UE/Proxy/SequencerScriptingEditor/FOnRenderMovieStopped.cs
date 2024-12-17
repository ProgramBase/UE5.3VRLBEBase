using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerScriptingEditor
{
	public class FOnRenderMovieStopped : FDelegate<Action<bool>>
	{
		public FOnRenderMovieStopped() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnRenderMovieStopped() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuccess;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
