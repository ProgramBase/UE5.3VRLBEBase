using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.BreakEventCallbackWrapper")]
	public partial class FBreakEventCallbackWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosSolverEngine.BreakEventCallbackWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBreakEventCallbackWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBreakEventCallbackWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBreakEventCallbackWrapper A, FBreakEventCallbackWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBreakEventCallbackWrapper A, FBreakEventCallbackWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBreakEventCallbackWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}