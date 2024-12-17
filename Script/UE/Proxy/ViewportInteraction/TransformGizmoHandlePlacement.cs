using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.TransformGizmoHandlePlacement")]
	public partial class FTransformGizmoHandlePlacement : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ViewportInteraction.TransformGizmoHandlePlacement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformGizmoHandlePlacement() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTransformGizmoHandlePlacement() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTransformGizmoHandlePlacement A, FTransformGizmoHandlePlacement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformGizmoHandlePlacement A, FTransformGizmoHandlePlacement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformGizmoHandlePlacement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}