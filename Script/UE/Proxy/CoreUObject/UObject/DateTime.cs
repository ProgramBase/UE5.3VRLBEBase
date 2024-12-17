using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DateTime")]
	public partial class FDateTime : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.DateTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDateTime() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDateTime() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDateTime A, FDateTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDateTime A, FDateTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDateTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}