using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigTransformWorkflowOptions")]
	public partial class UControlRigTransformWorkflowOptions : UControlRigWorkflowOptions, IStaticClass
	{
		public ERigTransformType TransformType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformType, __ReturnBuffer);

					return *(ERigTransformType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigTransformWorkflowOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FRigVMUserWorkflow> ProvideWorkflows(UObject InSubject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSubject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ProvideWorkflows, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigVMUserWorkflow>*)__ReturnBuffer;
			}
		}

		private static uint __TransformType = 0;

		private static uint __ProvideWorkflows = 0;
	}
}