using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetaSoundSourceFactory")]
	public partial class UMetaSoundSourceFactory : UMetaSoundBaseFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetaSoundSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}