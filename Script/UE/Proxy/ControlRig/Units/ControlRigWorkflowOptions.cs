using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigWorkflowOptions")]
	public partial class UControlRigWorkflowOptions : URigVMUserWorkflowOptions, IStaticClass
	{
		public URigHierarchy Hierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __ReturnBuffer);

					return *(URigHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __InBuffer);
				}
			}
		}

		public TArray<FRigElementKey> Selection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Selection, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Selection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigWorkflowOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool EnsureAtLeastOneRigElementSelected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __EnsureAtLeastOneRigElementSelected, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Hierarchy = 0;

		private static uint __Selection = 0;

		private static uint __EnsureAtLeastOneRigElementSelected = 0;
	}
}