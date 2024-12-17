using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMByteCodeStatistics")]
	public partial class FRigVMByteCodeStatistics : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMByteCodeStatistics");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMByteCodeStatistics() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMByteCodeStatistics() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMByteCodeStatistics A, FRigVMByteCodeStatistics B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMByteCodeStatistics A, FRigVMByteCodeStatistics B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMByteCodeStatistics;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int InstructionCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstructionCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstructionCount, __InBuffer);
				}
			}
		}

		public int DataBytes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataBytes, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataBytes, __InBuffer);
				}
			}
		}

		private static uint __InstructionCount = 0;

		private static uint __DataBytes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}