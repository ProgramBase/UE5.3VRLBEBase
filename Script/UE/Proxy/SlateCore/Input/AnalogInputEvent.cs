using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.AnalogInputEvent")]
	public partial class FAnalogInputEvent : FKeyEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.AnalogInputEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnalogInputEvent()
		{
		}

		public static bool operator ==(FAnalogInputEvent A, FAnalogInputEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnalogInputEvent A, FAnalogInputEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnalogInputEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}