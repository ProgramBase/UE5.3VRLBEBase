using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMBranchInfo")]
	public partial class FRigVMBranchInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMBranchInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMBranchInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMBranchInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMBranchInfo A, FRigVMBranchInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMBranchInfo A, FRigVMBranchInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMBranchInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Index
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Index, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Index, __InBuffer);
				}
			}
		}

		public FName Label
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Label, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Label, __InBuffer);
				}
			}
		}

		public int InstructionIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstructionIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstructionIndex, __InBuffer);
				}
			}
		}

		public int ArgumentIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArgumentIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArgumentIndex, __InBuffer);
				}
			}
		}

		public ushort FirstInstruction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FirstInstruction, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FirstInstruction, __InBuffer);
				}
			}
		}

		public ushort LastInstruction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastInstruction, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastInstruction, __InBuffer);
				}
			}
		}

		private static uint __Index = 0;

		private static uint __Label = 0;

		private static uint __InstructionIndex = 0;

		private static uint __ArgumentIndex = 0;

		private static uint __FirstInstruction = 0;

		private static uint __LastInstruction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}