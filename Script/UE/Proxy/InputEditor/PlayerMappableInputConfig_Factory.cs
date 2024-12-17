using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.PlayerMappableInputConfig_Factory")]
	public partial class UPlayerMappableInputConfig_Factory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.PlayerMappableInputConfig_Factory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}