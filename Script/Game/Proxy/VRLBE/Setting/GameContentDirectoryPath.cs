using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpCore
{
	[PathName("/Script/UnrealCSharpCore.GameContentDirectoryPath")]
	public partial class FGameContentDirectoryPath : FDirectoryPath, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealCSharpCore.GameContentDirectoryPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameContentDirectoryPath()
		{
		}

		public static bool operator ==(FGameContentDirectoryPath A, FGameContentDirectoryPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameContentDirectoryPath A, FGameContentDirectoryPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameContentDirectoryPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}