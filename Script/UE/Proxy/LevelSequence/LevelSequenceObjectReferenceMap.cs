using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceObjectReferenceMap")]
	public partial class FLevelSequenceObjectReferenceMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceObjectReferenceMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceObjectReferenceMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceObjectReferenceMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceObjectReferenceMap A, FLevelSequenceObjectReferenceMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceObjectReferenceMap A, FLevelSequenceObjectReferenceMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceObjectReferenceMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}