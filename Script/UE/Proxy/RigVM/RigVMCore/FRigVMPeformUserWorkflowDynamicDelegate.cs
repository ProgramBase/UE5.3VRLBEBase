using System;
using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVM
{
	public class FRigVMPeformUserWorkflowDynamicDelegate : FDelegate<Func<URigVMUserWorkflowOptions, UObject, bool>>
	{
		public FRigVMPeformUserWorkflowDynamicDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FRigVMPeformUserWorkflowDynamicDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public bool Execute(URigVMUserWorkflowOptions InOptions, UObject InController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FDelegateImplementation.FDelegate_PrimitiveExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}
	}
}
