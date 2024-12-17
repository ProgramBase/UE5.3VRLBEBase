using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StateMachineDebugData")]
	public partial class FStateMachineDebugData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StateMachineDebugData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStateMachineDebugData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStateMachineDebugData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStateMachineDebugData A, FStateMachineDebugData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStateMachineDebugData A, FStateMachineDebugData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStateMachineDebugData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}