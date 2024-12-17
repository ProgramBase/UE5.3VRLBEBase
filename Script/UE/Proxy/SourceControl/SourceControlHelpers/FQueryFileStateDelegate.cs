using System;
using Script.CoreUObject;
using Script.Library;
using Script.SourceControl;

namespace Script.SourceControl.SourceControlHelpers
{
	public class FQueryFileStateDelegate : FDelegate<Action<FSourceControlState>>
	{
		public FQueryFileStateDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FQueryFileStateDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FSourceControlState FileStateOut)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FileStateOut?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
