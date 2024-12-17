using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMUserWorkflowRegistry")]
	public partial class URigVMUserWorkflowRegistry : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMUserWorkflowRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnregisterProvider(int InHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InHandle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterProvider, __InBuffer);
			}
		}

		public virtual int RegisterProvider(UScriptStruct InStruct, FRigVMUserWorkflowProvider InProvider)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InProvider?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RegisterProvider, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMUserWorkflow> GetWorkflows(ERigVMUserWorkflowType InType, UScriptStruct InStruct, UObject InSubject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)InType;

				*(nint*)(__InBuffer + 1) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = InSubject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorkflows, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigVMUserWorkflow>*)__ReturnBuffer;
			}
		}

		public static URigVMUserWorkflowRegistry Get()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Get, __ReturnBuffer);

				return *(URigVMUserWorkflowRegistry*)__ReturnBuffer;
			}
		}

		private static uint __UnregisterProvider = 0;

		private static uint __RegisterProvider = 0;

		private static uint __GetWorkflows = 0;

		private static uint __Get = 0;
	}
}