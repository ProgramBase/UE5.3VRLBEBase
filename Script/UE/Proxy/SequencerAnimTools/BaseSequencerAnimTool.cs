using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerAnimTools
{
	[PathName("/Script/SequencerAnimTools.BaseSequencerAnimTool")]
	public partial class UBaseSequencerAnimTool : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerAnimTools.BaseSequencerAnimTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/SequencerAnimTools.BaseSequencerAnimTool")]
	public interface IBaseSequencerAnimTool : IInterface
	{
	}
}