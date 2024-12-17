using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserObjectListEntry")]
	public partial class UUserObjectListEntry : UUserListEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserObjectListEntry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UMG.UserObjectListEntry")]
	public interface IUserObjectListEntry : IUserListEntry
	{
		 void OnListItemObjectSet(UObject ListItemObject);
	}
}