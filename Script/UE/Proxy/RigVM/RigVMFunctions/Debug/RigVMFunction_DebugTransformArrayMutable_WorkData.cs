using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_DebugTransformArrayMutable_WorkData")]
	public partial class FRigVMFunction_DebugTransformArrayMutable_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_DebugTransformArrayMutable_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_DebugTransformArrayMutable_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMFunction_DebugTransformArrayMutable_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMFunction_DebugTransformArrayMutable_WorkData A, FRigVMFunction_DebugTransformArrayMutable_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_DebugTransformArrayMutable_WorkData A, FRigVMFunction_DebugTransformArrayMutable_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_DebugTransformArrayMutable_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTransform> DrawTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DrawTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DrawTransforms, __InBuffer);
				}
			}
		}

		private static uint __DrawTransforms = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}