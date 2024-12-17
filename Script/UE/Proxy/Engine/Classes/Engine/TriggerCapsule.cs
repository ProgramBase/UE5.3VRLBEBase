using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TriggerCapsule")]
	public partial class ATriggerCapsule : ATriggerBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TriggerCapsule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}