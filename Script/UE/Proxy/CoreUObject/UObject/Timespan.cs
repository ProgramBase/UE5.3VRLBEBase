using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Timespan")]
	public partial class FTimespan : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Timespan");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimespan() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimespan() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimespan A, FTimespan B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimespan A, FTimespan B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimespan;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}