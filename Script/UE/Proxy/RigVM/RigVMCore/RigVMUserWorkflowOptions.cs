using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMUserWorkflowOptions")]
	public partial class URigVMUserWorkflowOptions : UObject, IStaticClass
	{
		public UObject Subject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Subject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Subject, __InBuffer);
				}
			}
		}

		public FRigVMUserWorkflow Workflow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Workflow, __ReturnBuffer);

					return *(FRigVMUserWorkflow*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Workflow, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMUserWorkflowOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool RequiresDialog()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __RequiresDialog, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ReportWarning(FString InMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMessage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReportWarning, __InBuffer);
			}
		}

		public virtual void ReportInfo(FString InMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMessage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReportInfo, __InBuffer);
			}
		}

		public virtual void ReportError(FString InMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMessage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReportError, __InBuffer);
			}
		}

		public new bool IsValid()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsValid, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Subject = 0;

		private static uint __Workflow = 0;

		private static uint __RequiresDialog = 0;

		private static uint __ReportWarning = 0;

		private static uint __ReportInfo = 0;

		private static uint __ReportError = 0;

		private static uint __IsValid = 0;
	}
}