using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintConstantData")]
	public partial class FAnimBlueprintConstantData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimBlueprintConstantData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimBlueprintConstantData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimBlueprintConstantData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimBlueprintConstantData A, FAnimBlueprintConstantData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimBlueprintConstantData A, FAnimBlueprintConstantData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimBlueprintConstantData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}