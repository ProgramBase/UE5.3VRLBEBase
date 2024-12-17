using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphNode_Base")]
	public partial class USoundCueGraphNode_Base : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundCueGraphNode_Base");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}