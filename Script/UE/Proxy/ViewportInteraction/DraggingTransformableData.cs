using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.DraggingTransformableData")]
	public partial class FDraggingTransformableData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ViewportInteraction.DraggingTransformableData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDraggingTransformableData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDraggingTransformableData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDraggingTransformableData A, FDraggingTransformableData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDraggingTransformableData A, FDraggingTransformableData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDraggingTransformableData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}