using Script.CoreUObject;
using Script.Library;

namespace Script.WorldBrowser
{
	[PathName("/Script/WorldBrowser.LevelFolderProps")]
	public partial class FLevelFolderProps : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WorldBrowser.LevelFolderProps");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelFolderProps() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelFolderProps() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelFolderProps A, FLevelFolderProps B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelFolderProps A, FLevelFolderProps B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelFolderProps;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}