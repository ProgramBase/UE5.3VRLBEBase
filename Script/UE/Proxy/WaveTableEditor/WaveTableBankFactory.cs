using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.WaveTableEditor
{
	[PathName("/Script/WaveTableEditor.WaveTableBankFactory")]
	public partial class UWaveTableBankFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WaveTableEditor.WaveTableBankFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}