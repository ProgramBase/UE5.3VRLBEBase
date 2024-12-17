using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDrawContainer")]
	public partial class FRigVMDrawContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDrawContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDrawContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMDrawContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMDrawContainer A, FRigVMDrawContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDrawContainer A, FRigVMDrawContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDrawContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigVMDrawInstruction> Instructions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Instructions, __ReturnBuffer);

					return *(TArray<FRigVMDrawInstruction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Instructions, __InBuffer);
				}
			}
		}

		private static uint __Instructions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}