using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StateMachineStateDebugData")]
	public partial class FStateMachineStateDebugData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StateMachineStateDebugData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStateMachineStateDebugData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStateMachineStateDebugData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStateMachineStateDebugData A, FStateMachineStateDebugData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStateMachineStateDebugData A, FStateMachineStateDebugData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStateMachineStateDebugData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}