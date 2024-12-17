using Script.CoreUObject;
using Script.TypedElementFramework;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorElementCounterInterface")]
	public partial class UActorElementCounterInterface : UObject, IStaticClass, ITypedElementCounterInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorElementCounterInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ExecuteUbergraph = 0;
	}
}