using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.CrumblingEventCallbackWrapper")]
	public partial class FCrumblingEventCallbackWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosSolverEngine.CrumblingEventCallbackWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCrumblingEventCallbackWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCrumblingEventCallbackWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCrumblingEventCallbackWrapper A, FCrumblingEventCallbackWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCrumblingEventCallbackWrapper A, FCrumblingEventCallbackWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCrumblingEventCallbackWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}