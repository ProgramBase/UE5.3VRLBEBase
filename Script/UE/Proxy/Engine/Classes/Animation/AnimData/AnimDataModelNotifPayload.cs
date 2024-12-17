using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimDataModelNotifPayload")]
	public partial class FAnimDataModelNotifPayload : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimDataModelNotifPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimDataModelNotifPayload() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimDataModelNotifPayload() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimDataModelNotifPayload A, FAnimDataModelNotifPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimDataModelNotifPayload A, FAnimDataModelNotifPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimDataModelNotifPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}