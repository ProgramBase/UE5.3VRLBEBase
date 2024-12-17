using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SynthesisEditor
{
	[PathName("/Script/SynthesisEditor.AudioImpulseResponseFactory")]
	public partial class UAudioImpulseResponseFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SynthesisEditor.AudioImpulseResponseFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}