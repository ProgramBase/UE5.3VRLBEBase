using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FallbackStruct")]
	public partial class FFallbackStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FallbackStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFallbackStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFallbackStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFallbackStruct A, FFallbackStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFallbackStruct A, FFallbackStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFallbackStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}