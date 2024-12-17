using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystemInstance_NodeRelevancy")]
	public partial class FAnimSubsystemInstance_NodeRelevancy : FAnimSubsystemInstance, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystemInstance_NodeRelevancy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystemInstance_NodeRelevancy()
		{
		}

		public static bool operator ==(FAnimSubsystemInstance_NodeRelevancy A, FAnimSubsystemInstance_NodeRelevancy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystemInstance_NodeRelevancy A, FAnimSubsystemInstance_NodeRelevancy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystemInstance_NodeRelevancy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}