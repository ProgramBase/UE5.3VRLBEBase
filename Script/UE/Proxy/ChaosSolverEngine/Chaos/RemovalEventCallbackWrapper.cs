using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.RemovalEventCallbackWrapper")]
	public partial class FRemovalEventCallbackWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosSolverEngine.RemovalEventCallbackWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRemovalEventCallbackWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRemovalEventCallbackWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRemovalEventCallbackWrapper A, FRemovalEventCallbackWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRemovalEventCallbackWrapper A, FRemovalEventCallbackWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRemovalEventCallbackWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}