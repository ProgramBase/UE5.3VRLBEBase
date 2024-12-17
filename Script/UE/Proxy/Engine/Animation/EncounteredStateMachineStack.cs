using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EncounteredStateMachineStack")]
	public partial class FEncounteredStateMachineStack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EncounteredStateMachineStack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEncounteredStateMachineStack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEncounteredStateMachineStack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEncounteredStateMachineStack A, FEncounteredStateMachineStack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEncounteredStateMachineStack A, FEncounteredStateMachineStack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEncounteredStateMachineStack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}