using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioPanelWidgetInterface")]
	public partial class UAudioPanelWidgetInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioPanelWidgetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.AudioPanelWidgetInterface")]
	public interface IAudioPanelWidgetInterface : IInterface
	{
		 FName GetIconBrushName();

		 FText GetEditorName();
	}
}