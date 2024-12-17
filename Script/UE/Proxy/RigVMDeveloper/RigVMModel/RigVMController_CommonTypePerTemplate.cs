using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMController_CommonTypePerTemplate")]
	public partial class FRigVMController_CommonTypePerTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMController_CommonTypePerTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMController_CommonTypePerTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMController_CommonTypePerTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMController_CommonTypePerTemplate A, FRigVMController_CommonTypePerTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMController_CommonTypePerTemplate A, FRigVMController_CommonTypePerTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMController_CommonTypePerTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, int> Counts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Counts, __ReturnBuffer);

					return *(TMap<FString, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Counts, __InBuffer);
				}
			}
		}

		private static uint __Counts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}