using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SelectedSocketInfo")]
	public partial class FSelectedSocketInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.SelectedSocketInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSelectedSocketInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSelectedSocketInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSelectedSocketInfo A, FSelectedSocketInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSelectedSocketInfo A, FSelectedSocketInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSelectedSocketInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}