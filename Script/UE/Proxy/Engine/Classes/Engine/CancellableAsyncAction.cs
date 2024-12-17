using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CancellableAsyncAction")]
	public partial class UCancellableAsyncAction : UBlueprintAsyncActionBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CancellableAsyncAction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void Cancel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Cancel);
			}
		}

		private static uint __IsActive = 0;

		private static uint __Cancel = 0;
	}
}