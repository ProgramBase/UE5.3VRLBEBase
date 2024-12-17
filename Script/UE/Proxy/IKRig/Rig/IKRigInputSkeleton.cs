using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRigInputSkeleton")]
	public partial class FIKRigInputSkeleton : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.IKRigInputSkeleton");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRigInputSkeleton() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIKRigInputSkeleton() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIKRigInputSkeleton A, FIKRigInputSkeleton B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRigInputSkeleton A, FIKRigInputSkeleton B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRigInputSkeleton;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}