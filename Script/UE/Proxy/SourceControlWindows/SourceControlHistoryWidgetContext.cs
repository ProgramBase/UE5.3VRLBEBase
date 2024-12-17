using Script.CoreUObject;
using Script.Library;

namespace Script.SourceControlWindows
{
	[PathName("/Script/SourceControlWindows.SourceControlHistoryWidgetContext")]
	public partial class USourceControlHistoryWidgetContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SourceControlWindows.SourceControlHistoryWidgetContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}