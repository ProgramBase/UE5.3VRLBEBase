using Script.CoreUObject;
using Script.Library;

namespace Script.GraphEditor
{
	[PathName("/Script/GraphEditor.PinStructEditWrapper")]
	public partial class FPinStructEditWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GraphEditor.PinStructEditWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPinStructEditWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPinStructEditWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPinStructEditWrapper A, FPinStructEditWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPinStructEditWrapper A, FPinStructEditWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPinStructEditWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}