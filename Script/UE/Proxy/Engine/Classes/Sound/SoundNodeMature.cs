using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundNodeMature")]
	public partial class USoundNodeMature : USoundNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundNodeMature");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}