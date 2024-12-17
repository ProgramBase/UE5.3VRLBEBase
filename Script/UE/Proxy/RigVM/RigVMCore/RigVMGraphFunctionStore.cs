using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMGraphFunctionStore")]
	public partial class FRigVMGraphFunctionStore : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMGraphFunctionStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMGraphFunctionStore() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMGraphFunctionStore() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMGraphFunctionStore A, FRigVMGraphFunctionStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMGraphFunctionStore A, FRigVMGraphFunctionStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMGraphFunctionStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigVMGraphFunctionData> PublicFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PublicFunctions, __ReturnBuffer);

					return *(TArray<FRigVMGraphFunctionData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PublicFunctions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMGraphFunctionData> PrivateFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrivateFunctions, __ReturnBuffer);

					return *(TArray<FRigVMGraphFunctionData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrivateFunctions, __InBuffer);
				}
			}
		}

		private static uint __PublicFunctions = 0;

		private static uint __PrivateFunctions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}