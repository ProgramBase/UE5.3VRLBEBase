using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SoftClassPath")]
	public partial class FSoftClassPath : FSoftObjectPath, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.SoftClassPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftClassPath()
		{
		}

		public static bool operator ==(FSoftClassPath A, FSoftClassPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftClassPath A, FSoftClassPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftClassPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}