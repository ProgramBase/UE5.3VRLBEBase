using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimPoseContext")]
	public partial class FAnimPoseContext : FAnimExecutionContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimPoseContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimPoseContext()
		{
		}

		public static bool operator ==(FAnimPoseContext A, FAnimPoseContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimPoseContext A, FAnimPoseContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimPoseContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}