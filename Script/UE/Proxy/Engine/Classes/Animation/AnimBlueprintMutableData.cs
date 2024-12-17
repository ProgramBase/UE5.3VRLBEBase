using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintMutableData")]
	public partial class FAnimBlueprintMutableData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimBlueprintMutableData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimBlueprintMutableData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimBlueprintMutableData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimBlueprintMutableData A, FAnimBlueprintMutableData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimBlueprintMutableData A, FAnimBlueprintMutableData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimBlueprintMutableData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}