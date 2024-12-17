using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISense_Blueprint")]
	public partial class UAISense_Blueprint : UAISense, IStaticClass
	{
		public TSubclassOf<UUserDefinedStruct> ListenerDataType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerDataType, __ReturnBuffer);

					return *(TSubclassOf<UUserDefinedStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerDataType, __InBuffer);
				}
			}
		}

		public TArray<UAIPerceptionComponent> ListenerContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerContainer, __ReturnBuffer);

					return *(TArray<UAIPerceptionComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListenerContainer, __InBuffer);
				}
			}
		}

		public TArray<UAISenseEvent> UnprocessedEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnprocessedEvents, __ReturnBuffer);

					return *(TArray<UAISenseEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnprocessedEvents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISense_Blueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float OnUpdate(TArray<UAISenseEvent> EventsToProcess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventsToProcess?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __OnUpdate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="PerceptionComponent">
		/// is ActorListener's AIPerceptionComponent instance
		/// </param>
		public virtual void OnListenerUpdated(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorListener?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PerceptionComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnListenerUpdated, __InBuffer);
			}
		}

		/// <param name="PerceptionComponent">
		/// is ActorListener's AIPerceptionComponent instance
		/// </param>
		public virtual void OnListenerUnregistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorListener?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PerceptionComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnListenerUnregistered, __InBuffer);
			}
		}

		/// <param name="PerceptionComponent">
		/// is ActorListener's AIPerceptionComponent instance
		/// </param>
		public virtual void OnListenerRegistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorListener?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PerceptionComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnListenerRegistered, __InBuffer);
			}
		}

		public virtual void K2_OnNewPawn(APawn NewPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnNewPawn, __InBuffer);
			}
		}

		public virtual void GetAllListenerComponents(ref TArray<UAIPerceptionComponent> ListenerComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ListenerComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllListenerComponents, __InBuffer, __OutBuffer);

				ListenerComponents = *(TArray<UAIPerceptionComponent>*)(__OutBuffer);

			}
		}

		public virtual void GetAllListenerActors(ref TArray<AActor> ListenerActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ListenerActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllListenerActors, __InBuffer, __OutBuffer);

				ListenerActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		private static uint __ListenerDataType = 0;

		private static uint __ListenerContainer = 0;

		private static uint __UnprocessedEvents = 0;

		private static uint __OnUpdate = 0;

		private static uint __OnListenerUpdated = 0;

		private static uint __OnListenerUnregistered = 0;

		private static uint __OnListenerRegistered = 0;

		private static uint __K2_OnNewPawn = 0;

		private static uint __GetAllListenerComponents = 0;

		private static uint __GetAllListenerActors = 0;
	}
}