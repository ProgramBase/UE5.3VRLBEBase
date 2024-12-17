using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.SequenceTickManagerWidgetData")]
	public partial class FSequenceTickManagerWidgetData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.SequenceTickManagerWidgetData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequenceTickManagerWidgetData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequenceTickManagerWidgetData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequenceTickManagerWidgetData A, FSequenceTickManagerWidgetData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequenceTickManagerWidgetData A, FSequenceTickManagerWidgetData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequenceTickManagerWidgetData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}