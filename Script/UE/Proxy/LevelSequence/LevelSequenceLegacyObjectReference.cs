using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceLegacyObjectReference")]
	public partial class FLevelSequenceLegacyObjectReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceLegacyObjectReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceLegacyObjectReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceLegacyObjectReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceLegacyObjectReference A, FLevelSequenceLegacyObjectReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceLegacyObjectReference A, FLevelSequenceLegacyObjectReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceLegacyObjectReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}