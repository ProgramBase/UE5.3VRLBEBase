using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.EndpointSubmixFactory")]
	public partial class UEndpointSubmixFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.EndpointSubmixFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}