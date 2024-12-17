using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.WmfMediaEditor
{
	[PathName("/Script/WmfMediaEditor.WmfFileMediaSourceFactory")]
	public partial class UWmfFileMediaSourceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WmfMediaEditor.WmfFileMediaSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}