using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetaSoundFactory")]
	public partial class UMetaSoundFactory : UMetaSoundBaseFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetaSoundFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}