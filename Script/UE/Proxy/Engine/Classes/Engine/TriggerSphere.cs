using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TriggerSphere")]
	public partial class ATriggerSphere : ATriggerBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TriggerSphere");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}