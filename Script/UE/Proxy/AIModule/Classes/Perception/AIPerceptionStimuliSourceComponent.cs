using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIPerceptionStimuliSourceComponent")]
	public partial class UAIPerceptionStimuliSourceComponent : UActorComponent, IStaticClass
	{
		public bool bAutoRegisterAsSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterAsSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterAsSource, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UAISense>> RegisterAsSourceForSenses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisterAsSourceForSenses, __ReturnBuffer);

					return *(TArray<TSubclassOf<UAISense>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisterAsSourceForSenses, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIPerceptionStimuliSourceComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnregisterFromSense(TSubclassOf<UAISense> SenseClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SenseClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterFromSense, __InBuffer);
			}
		}

		public virtual void UnregisterFromPerceptionSystem()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnregisterFromPerceptionSystem);
			}
		}

		public virtual void RegisterWithPerceptionSystem()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RegisterWithPerceptionSystem);
			}
		}

		public virtual void RegisterForSense(TSubclassOf<UAISense> SenseClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SenseClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterForSense, __InBuffer);
			}
		}

		private static uint __bAutoRegisterAsSource = 0;

		private static uint __RegisterAsSourceForSenses = 0;

		private static uint __UnregisterFromSense = 0;

		private static uint __UnregisterFromPerceptionSystem = 0;

		private static uint __RegisterWithPerceptionSystem = 0;

		private static uint __RegisterForSense = 0;
	}
}