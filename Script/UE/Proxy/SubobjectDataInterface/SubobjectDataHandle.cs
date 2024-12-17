using Script.CoreUObject;
using Script.Library;

namespace Script.SubobjectDataInterface
{
	[PathName("/Script/SubobjectDataInterface.SubobjectDataHandle")]
	public partial class FSubobjectDataHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SubobjectDataInterface.SubobjectDataHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubobjectDataHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubobjectDataHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubobjectDataHandle A, FSubobjectDataHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubobjectDataHandle A, FSubobjectDataHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubobjectDataHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}