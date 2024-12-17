using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SMInstanceElementIdMapTransactor")]
	public partial class USMInstanceElementIdMapTransactor : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SMInstanceElementIdMapTransactor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}