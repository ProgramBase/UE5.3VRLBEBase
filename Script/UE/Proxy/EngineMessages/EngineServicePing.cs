using Script.CoreUObject;
using Script.Library;

namespace Script.EngineMessages
{
	[PathName("/Script/EngineMessages.EngineServicePing")]
	public partial class FEngineServicePing : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineMessages.EngineServicePing");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineServicePing() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineServicePing() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineServicePing A, FEngineServicePing B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineServicePing A, FEngineServicePing B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineServicePing;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}