using System;
using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	public class FRigVMUserWorkflowProvider : FDelegate<Func<UObject, TArray<FRigVMUserWorkflow>>>
	{
		public FRigVMUserWorkflowProvider() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FRigVMUserWorkflowProvider() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public TArray<FRigVMUserWorkflow> Execute(UObject InSubject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSubject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_CompoundExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigVMUserWorkflow>*)__ReturnBuffer;
			}
		}
	}
}
