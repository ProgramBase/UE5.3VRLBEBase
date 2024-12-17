using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetComponentInstanceData")]
	public partial class FWidgetComponentInstanceData : FSceneComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.WidgetComponentInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetComponentInstanceData()
		{
		}

		public static bool operator ==(FWidgetComponentInstanceData A, FWidgetComponentInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetComponentInstanceData A, FWidgetComponentInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetComponentInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}