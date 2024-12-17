using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintDebugData")]
	public partial class FAnimBlueprintDebugData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimBlueprintDebugData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimBlueprintDebugData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimBlueprintDebugData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimBlueprintDebugData A, FAnimBlueprintDebugData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimBlueprintDebugData A, FAnimBlueprintDebugData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimBlueprintDebugData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}