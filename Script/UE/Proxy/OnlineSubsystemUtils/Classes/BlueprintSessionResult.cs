using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.BlueprintSessionResult")]
	public partial class FBlueprintSessionResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystemUtils.BlueprintSessionResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintSessionResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintSessionResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintSessionResult A, FBlueprintSessionResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintSessionResult A, FBlueprintSessionResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintSessionResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}