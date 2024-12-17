using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetStateBitfield")]
	public partial class FWidgetStateBitfield : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.WidgetStateBitfield");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetStateBitfield() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetStateBitfield() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetStateBitfield A, FWidgetStateBitfield B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetStateBitfield A, FWidgetStateBitfield B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetStateBitfield;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}