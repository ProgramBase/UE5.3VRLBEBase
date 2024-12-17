using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.MotionEvent")]
	public partial class FMotionEvent : FInputEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.MotionEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMotionEvent()
		{
		}

		public static bool operator ==(FMotionEvent A, FMotionEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMotionEvent A, FMotionEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMotionEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}