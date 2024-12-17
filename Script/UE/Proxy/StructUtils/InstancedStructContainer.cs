using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.InstancedStructContainer")]
	public partial class FInstancedStructContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtils.InstancedStructContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstancedStructContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInstancedStructContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInstancedStructContainer A, FInstancedStructContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstancedStructContainer A, FInstancedStructContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstancedStructContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}