using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserListEntry")]
	public partial class UUserListEntry : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserListEntry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UMG.UserListEntry")]
	public interface IUserListEntry : IInterface
	{
		 void BP_OnItemSelectionChanged(bool bIsSelected);

		 void BP_OnItemExpansionChanged(bool bIsExpanded);

		 void BP_OnEntryReleased();
	}
}