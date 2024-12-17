using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintMacroCosmeticInfo")]
	public partial class FBlueprintMacroCosmeticInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintMacroCosmeticInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintMacroCosmeticInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintMacroCosmeticInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintMacroCosmeticInfo A, FBlueprintMacroCosmeticInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintMacroCosmeticInfo A, FBlueprintMacroCosmeticInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintMacroCosmeticInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}