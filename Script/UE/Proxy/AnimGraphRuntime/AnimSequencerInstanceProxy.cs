using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimSequencerInstanceProxy")]
	public partial class FAnimSequencerInstanceProxy : FAnimInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimSequencerInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSequencerInstanceProxy()
		{
		}

		public static bool operator ==(FAnimSequencerInstanceProxy A, FAnimSequencerInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSequencerInstanceProxy A, FAnimSequencerInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSequencerInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}