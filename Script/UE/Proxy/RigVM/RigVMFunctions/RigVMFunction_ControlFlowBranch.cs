using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_ControlFlowBranch")]
	public partial class FRigVMFunction_ControlFlowBranch : FRigVMFunction_ControlFlowBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_ControlFlowBranch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_ControlFlowBranch()
		{
		}

		public static bool operator ==(FRigVMFunction_ControlFlowBranch A, FRigVMFunction_ControlFlowBranch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_ControlFlowBranch A, FRigVMFunction_ControlFlowBranch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_ControlFlowBranch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigVMExecuteContext ExecuteContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteContext, __ReturnBuffer);

					return *(FRigVMExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteContext, __InBuffer);
				}
			}
		}

		public bool Condition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Condition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Condition, __InBuffer);
				}
			}
		}

		public FRigVMExecuteContext True
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __True, __ReturnBuffer);

					return *(FRigVMExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __True, __InBuffer);
				}
			}
		}

		public FRigVMExecuteContext False
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __False, __ReturnBuffer);

					return *(FRigVMExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __False, __InBuffer);
				}
			}
		}

		public FRigVMExecuteContext Completed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Completed, __ReturnBuffer);

					return *(FRigVMExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Completed, __InBuffer);
				}
			}
		}

		public FName BlockToRun
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlockToRun, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlockToRun, __InBuffer);
				}
			}
		}

		private static uint __ExecuteContext = 0;

		private static uint __Condition = 0;

		private static uint __True = 0;

		private static uint __False = 0;

		private static uint __Completed = 0;

		private static uint __BlockToRun = 0;

	}
}