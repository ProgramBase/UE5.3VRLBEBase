using Script.CoreUObject;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphNode_Root")]
	public partial class USoundCueGraphNode_Root : USoundCueGraphNode_Base, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundCueGraphNode_Root");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}