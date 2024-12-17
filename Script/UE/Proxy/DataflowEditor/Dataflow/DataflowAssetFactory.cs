using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.DataflowEditor
{
	[PathName("/Script/DataflowEditor.DataflowAssetFactory")]
	public partial class UDataflowAssetFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEditor.DataflowAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}