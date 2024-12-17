using Script.CoreUObject;
using Script.Engine;
using Script.ChaosSolverEngine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.ChaosDestructionListener")]
	public partial class UChaosDestructionListener : USceneComponent, IStaticClass
	{
		public bool bIsCollisionEventListeningEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCollisionEventListeningEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCollisionEventListeningEnabled, __InBuffer);
				}
			}
		}

		public bool bIsBreakingEventListeningEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBreakingEventListeningEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBreakingEventListeningEnabled, __InBuffer);
				}
			}
		}

		public bool bIsTrailingEventListeningEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsTrailingEventListeningEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsTrailingEventListeningEnabled, __InBuffer);
				}
			}
		}

		public bool bIsRemovalEventListeningEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRemovalEventListeningEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRemovalEventListeningEnabled, __InBuffer);
				}
			}
		}

		public FChaosCollisionEventRequestSettings CollisionEventRequestSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionEventRequestSettings, __ReturnBuffer);

					return *(FChaosCollisionEventRequestSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionEventRequestSettings, __InBuffer);
				}
			}
		}

		public FChaosBreakingEventRequestSettings BreakingEventRequestSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BreakingEventRequestSettings, __ReturnBuffer);

					return *(FChaosBreakingEventRequestSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BreakingEventRequestSettings, __InBuffer);
				}
			}
		}

		public FChaosTrailingEventRequestSettings TrailingEventRequestSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrailingEventRequestSettings, __ReturnBuffer);

					return *(FChaosTrailingEventRequestSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrailingEventRequestSettings, __InBuffer);
				}
			}
		}

		public FChaosRemovalEventRequestSettings RemovalEventRequestSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RemovalEventRequestSettings, __ReturnBuffer);

					return *(FChaosRemovalEventRequestSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RemovalEventRequestSettings, __InBuffer);
				}
			}
		}

		public TSet<AChaosSolverActor> ChaosSolverActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosSolverActors, __ReturnBuffer);

					return *(TSet<AChaosSolverActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosSolverActors, __InBuffer);
				}
			}
		}

		public TSet<AGeometryCollectionActor> GeometryCollectionActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionActors, __ReturnBuffer);

					return *(TSet<AGeometryCollectionActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionActors, __InBuffer);
				}
			}
		}

		public FOnChaosCollisionEvents OnCollisionEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCollisionEvents, __ReturnBuffer);

					return *(FOnChaosCollisionEvents*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCollisionEvents, __InBuffer);
				}
			}
		}

		public FOnChaosBreakingEvents OnBreakingEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnBreakingEvents, __ReturnBuffer);

					return *(FOnChaosBreakingEvents*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnBreakingEvents, __InBuffer);
				}
			}
		}

		public FOnChaosTrailingEvents OnTrailingEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTrailingEvents, __ReturnBuffer);

					return *(FOnChaosTrailingEvents*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTrailingEvents, __InBuffer);
				}
			}
		}

		public FOnChaosRemovalEvents OnRemovalEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnRemovalEvents, __ReturnBuffer);

					return *(FOnChaosRemovalEvents*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnRemovalEvents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.ChaosDestructionListener");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SortTrailingEvents(ref TArray<FChaosTrailingEventData> TrailingEvents, EChaosTrailingSortMethod SortMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = TrailingEvents?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SortMethod;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SortTrailingEvents, __InBuffer, __OutBuffer);

				TrailingEvents = *(TArray<FChaosTrailingEventData>*)(__OutBuffer);

			}
		}

		public virtual void SortRemovalEvents(ref TArray<FChaosRemovalEventData> RemovalEvents, EChaosRemovalSortMethod SortMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = RemovalEvents?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SortMethod;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SortRemovalEvents, __InBuffer, __OutBuffer);

				RemovalEvents = *(TArray<FChaosRemovalEventData>*)(__OutBuffer);

			}
		}

		public virtual void SortCollisionEvents(ref TArray<FChaosCollisionEventData> CollisionEvents, EChaosCollisionSortMethod SortMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = CollisionEvents?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SortMethod;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SortCollisionEvents, __InBuffer, __OutBuffer);

				CollisionEvents = *(TArray<FChaosCollisionEventData>*)(__OutBuffer);

			}
		}

		public virtual void SortBreakingEvents(ref TArray<FChaosBreakingEventData> BreakingEvents, EChaosBreakingSortMethod SortMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BreakingEvents?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SortMethod;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SortBreakingEvents, __InBuffer, __OutBuffer);

				BreakingEvents = *(TArray<FChaosBreakingEventData>*)(__OutBuffer);

			}
		}

		public virtual void SetTrailingEventRequestSettings(FChaosTrailingEventRequestSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTrailingEventRequestSettings, __InBuffer);
			}
		}

		public virtual void SetTrailingEventEnabled(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTrailingEventEnabled, __InBuffer);
			}
		}

		public virtual void SetRemovalEventRequestSettings(FChaosRemovalEventRequestSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRemovalEventRequestSettings, __InBuffer);
			}
		}

		public virtual void SetRemovalEventEnabled(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRemovalEventEnabled, __InBuffer);
			}
		}

		public virtual void SetCollisionEventRequestSettings(FChaosCollisionEventRequestSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionEventRequestSettings, __InBuffer);
			}
		}

		public virtual void SetCollisionEventEnabled(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollisionEventEnabled, __InBuffer);
			}
		}

		public virtual void SetBreakingEventRequestSettings(FChaosBreakingEventRequestSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBreakingEventRequestSettings, __InBuffer);
			}
		}

		public virtual void SetBreakingEventEnabled(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBreakingEventEnabled, __InBuffer);
			}
		}

		public virtual void RemoveGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GeometryCollectionActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveGeometryCollectionActor, __InBuffer);
			}
		}

		public virtual void RemoveChaosSolverActor(AChaosSolverActor ChaosSolverActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChaosSolverActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveChaosSolverActor, __InBuffer);
			}
		}

		public virtual bool IsEventListening()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEventListening, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GeometryCollectionActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddGeometryCollectionActor, __InBuffer);
			}
		}

		public virtual void AddChaosSolverActor(AChaosSolverActor ChaosSolverActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChaosSolverActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddChaosSolverActor, __InBuffer);
			}
		}

		private static uint __bIsCollisionEventListeningEnabled = 0;

		private static uint __bIsBreakingEventListeningEnabled = 0;

		private static uint __bIsTrailingEventListeningEnabled = 0;

		private static uint __bIsRemovalEventListeningEnabled = 0;

		private static uint __CollisionEventRequestSettings = 0;

		private static uint __BreakingEventRequestSettings = 0;

		private static uint __TrailingEventRequestSettings = 0;

		private static uint __RemovalEventRequestSettings = 0;

		private static uint __ChaosSolverActors = 0;

		private static uint __GeometryCollectionActors = 0;

		private static uint __OnCollisionEvents = 0;

		private static uint __OnBreakingEvents = 0;

		private static uint __OnTrailingEvents = 0;

		private static uint __OnRemovalEvents = 0;

		private static uint __SortTrailingEvents = 0;

		private static uint __SortRemovalEvents = 0;

		private static uint __SortCollisionEvents = 0;

		private static uint __SortBreakingEvents = 0;

		private static uint __SetTrailingEventRequestSettings = 0;

		private static uint __SetTrailingEventEnabled = 0;

		private static uint __SetRemovalEventRequestSettings = 0;

		private static uint __SetRemovalEventEnabled = 0;

		private static uint __SetCollisionEventRequestSettings = 0;

		private static uint __SetCollisionEventEnabled = 0;

		private static uint __SetBreakingEventRequestSettings = 0;

		private static uint __SetBreakingEventEnabled = 0;

		private static uint __RemoveGeometryCollectionActor = 0;

		private static uint __RemoveChaosSolverActor = 0;

		private static uint __IsEventListening = 0;

		private static uint __AddGeometryCollectionActor = 0;

		private static uint __AddChaosSolverActor = 0;
	}
}