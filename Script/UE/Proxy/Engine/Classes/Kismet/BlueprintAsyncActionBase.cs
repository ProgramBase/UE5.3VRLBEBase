using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintAsyncActionBase")]
	public partial class UBlueprintAsyncActionBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintAsyncActionBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Activate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Activate);
			}
		}

		private static uint __Activate = 0;
	}
}