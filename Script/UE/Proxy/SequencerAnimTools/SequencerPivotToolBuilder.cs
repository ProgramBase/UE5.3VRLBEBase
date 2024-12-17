using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.SequencerAnimTools
{
	[PathName("/Script/SequencerAnimTools.SequencerPivotToolBuilder")]
	public partial class USequencerPivotToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerAnimTools.SequencerPivotToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}