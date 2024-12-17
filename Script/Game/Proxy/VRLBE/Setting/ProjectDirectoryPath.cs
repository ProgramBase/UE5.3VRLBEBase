using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpCore
{
	[PathName("/Script/UnrealCSharpCore.ProjectDirectoryPath")]
	public partial class FProjectDirectoryPath : FDirectoryPath, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealCSharpCore.ProjectDirectoryPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProjectDirectoryPath()
		{
		}

		public static bool operator ==(FProjectDirectoryPath A, FProjectDirectoryPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProjectDirectoryPath A, FProjectDirectoryPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProjectDirectoryPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}