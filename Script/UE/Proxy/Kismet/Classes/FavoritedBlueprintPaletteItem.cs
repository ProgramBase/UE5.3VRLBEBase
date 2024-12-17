using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.FavoritedBlueprintPaletteItem")]
	public partial class FFavoritedBlueprintPaletteItem : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Kismet.FavoritedBlueprintPaletteItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFavoritedBlueprintPaletteItem() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFavoritedBlueprintPaletteItem() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFavoritedBlueprintPaletteItem A, FFavoritedBlueprintPaletteItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFavoritedBlueprintPaletteItem A, FFavoritedBlueprintPaletteItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFavoritedBlueprintPaletteItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}