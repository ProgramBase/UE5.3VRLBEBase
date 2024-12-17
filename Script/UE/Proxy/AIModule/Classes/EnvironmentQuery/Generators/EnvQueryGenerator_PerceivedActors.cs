using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryGenerator_PerceivedActors")]
	public partial class UEnvQueryGenerator_PerceivedActors : UEnvQueryGenerator, IStaticClass
	{
		public TSubclassOf<AActor> AllowedActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowedActorClass, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowedActorClass, __InBuffer);
				}
			}
		}

		public FAIDataProviderFloatValue SearchRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SearchRadius, __ReturnBuffer);

					return *(FAIDataProviderFloatValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SearchRadius, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryContext> ListenerContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerContext, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerContext, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAISense> SenseToUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SenseToUse, __ReturnBuffer);

					return *(TSubclassOf<UAISense>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SenseToUse, __InBuffer);
				}
			}
		}

		public bool bIncludeKnownActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeKnownActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeKnownActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryGenerator_PerceivedActors");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AllowedActorClass = 0;

		private static uint __SearchRadius = 0;

		private static uint __ListenerContext = 0;

		private static uint __SenseToUse = 0;

		private static uint __bIncludeKnownActors = 0;
	}
}