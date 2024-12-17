using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SlatePlayInEditorInfo")]
	public partial class FSlatePlayInEditorInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.SlatePlayInEditorInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSlatePlayInEditorInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSlatePlayInEditorInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSlatePlayInEditorInfo A, FSlatePlayInEditorInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSlatePlayInEditorInfo A, FSlatePlayInEditorInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSlatePlayInEditorInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}