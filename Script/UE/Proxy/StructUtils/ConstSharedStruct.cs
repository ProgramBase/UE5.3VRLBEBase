using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.ConstSharedStruct")]
	public partial class FConstSharedStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtils.ConstSharedStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstSharedStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstSharedStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstSharedStruct A, FConstSharedStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstSharedStruct A, FConstSharedStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstSharedStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}