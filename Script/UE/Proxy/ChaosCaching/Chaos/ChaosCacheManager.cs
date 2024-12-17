using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.ChaosCacheManager")]
	public partial class AChaosCacheManager : AActor, IStaticClass
	{
		public UChaosCacheCollection CacheCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheCollection, __ReturnBuffer);

					return *(UChaosCacheCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheCollection, __InBuffer);
				}
			}
		}

		public ECacheMode CacheMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheMode, __ReturnBuffer);

					return *(ECacheMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheMode, __InBuffer);
				}
			}
		}

		public EStartMode StartMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartMode, __ReturnBuffer);

					return *(EStartMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartMode, __InBuffer);
				}
			}
		}

		public float StartTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __InBuffer);
				}
			}
		}

		public TArray<FObservedComponent> ObservedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObservedComponents, __ReturnBuffer);

					return *(TArray<FObservedComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObservedComponents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCaching.ChaosCacheManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InCacheName">
		/// Cache name to trigger
		/// </param>
		public virtual void TriggerComponentByCache(FName InCacheName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InCacheName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TriggerComponentByCache, __InBuffer);
			}
		}

		/// <param name="InComponent">
		/// Component to trigger
		/// </param>
		public virtual void TriggerComponent(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TriggerComponent, __InBuffer);
			}
		}

		public virtual void TriggerAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __TriggerAll);
			}
		}

		public virtual void SetStartTime(float InStartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InStartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartTime, __InBuffer);
			}
		}

		public virtual void SetCacheCollection(UChaosCacheCollection InCacheCollection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InCacheCollection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCacheCollection, __InBuffer);
			}
		}

		/// <param name="InIndex">
		/// Index of the component to reset
		/// </param>
		public virtual void ResetSingleTransform(int InIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetSingleTransform, __InBuffer);
			}
		}

		public virtual void ResetAllComponentTransforms()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetAllComponentTransforms);
			}
		}

		public virtual void EnablePlaybackByCache(FName InCacheName, bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InCacheName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnablePlaybackByCache, __InBuffer);
			}
		}

		public virtual void EnablePlayback(int Index, bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = Index;

				*(bool*)(__InBuffer + 4) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnablePlayback, __InBuffer);
			}
		}

		private static uint __CacheCollection = 0;

		private static uint __CacheMode = 0;

		private static uint __StartMode = 0;

		private static uint __StartTime = 0;

		private static uint __ObservedComponents = 0;

		private static uint __TriggerComponentByCache = 0;

		private static uint __TriggerComponent = 0;

		private static uint __TriggerAll = 0;

		private static uint __SetStartTime = 0;

		private static uint __SetCacheCollection = 0;

		private static uint __ResetSingleTransform = 0;

		private static uint __ResetAllComponentTransforms = 0;

		private static uint __EnablePlaybackByCache = 0;

		private static uint __EnablePlayback = 0;
	}
}