using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundfieldEndpointSubmixFactory")]
	public partial class USoundfieldEndpointSubmixFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundfieldEndpointSubmixFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}