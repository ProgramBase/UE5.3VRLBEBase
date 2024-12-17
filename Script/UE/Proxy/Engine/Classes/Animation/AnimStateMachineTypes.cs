using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimStateMachineTypes")]
	public partial class UAnimStateMachineTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimStateMachineTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}