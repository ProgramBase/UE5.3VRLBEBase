using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintActionMenuItem")]
	public partial class FBlueprintActionMenuItem : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Kismet.BlueprintActionMenuItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintActionMenuItem()
		{
		}

		public static bool operator ==(FBlueprintActionMenuItem A, FBlueprintActionMenuItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintActionMenuItem A, FBlueprintActionMenuItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintActionMenuItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}