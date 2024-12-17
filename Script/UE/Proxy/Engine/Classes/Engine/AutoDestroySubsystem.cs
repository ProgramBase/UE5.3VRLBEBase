using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AutoDestroySubsystem")]
	public partial class UAutoDestroySubsystem : UTickableWorldSubsystem, IStaticClass
	{
		public TArray<AActor> ActorsToPoll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorsToPoll, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorsToPoll, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AutoDestroySubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnActorEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnActorEndPlay, __InBuffer);
			}
		}

		private static uint __ActorsToPoll = 0;

		private static uint __OnActorEndPlay = 0;
	}
}