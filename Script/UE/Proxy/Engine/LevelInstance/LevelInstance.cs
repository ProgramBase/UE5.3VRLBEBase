using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelInstance")]
	public partial class ALevelInstance : AActor, IStaticClass, ILevelInstanceInterface
	{
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldAsset, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldAsset, __InBuffer);
				}
			}
		}

		public ULevelInstanceComponent LevelInstanceComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceComponent, __ReturnBuffer);

					return *(ULevelInstanceComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceComponent, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UWorld> CookedWorldAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CookedWorldAsset, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CookedWorldAsset, __InBuffer);
				}
			}
		}

		public FGuid LevelInstanceSpawnGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceSpawnGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceSpawnGuid, __InBuffer);
				}
			}
		}

		public ELevelInstanceRuntimeBehavior DesiredRuntimeBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredRuntimeBehavior, __ReturnBuffer);

					return *(ELevelInstanceRuntimeBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredRuntimeBehavior, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnloadLevelInstance()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnloadLevelInstance);
			}
		}

		public virtual bool SetWorldAsset(TSoftObjectPtr<UWorld> WorldAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetWorldAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void LoadLevelInstance()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __LoadLevelInstance);
			}
		}

		public virtual bool IsLoaded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLoaded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TSoftObjectPtr<UWorld> GetWorldAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWorldAsset, __ReturnBuffer);

				return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
			}
		}

		public virtual ULevel GetLoadedLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLoadedLevel, __ReturnBuffer);

				return *(ULevel*)__ReturnBuffer;
			}
		}

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

		public virtual void OnRep_LevelInstanceSpawnGuid()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_LevelInstanceSpawnGuid);
			}
		}

		private static uint __WorldAsset = 0;

		private static uint __LevelInstanceComponent = 0;

		private static uint __CookedWorldAsset = 0;

		private static uint __LevelInstanceSpawnGuid = 0;

		private static uint __DesiredRuntimeBehavior = 0;

		private static uint __UnloadLevelInstance = 0;

		private static uint __SetWorldAsset = 0;

		private static uint __LoadLevelInstance = 0;

		private static uint __IsLoaded = 0;

		private static uint __GetWorldAsset = 0;

		private static uint __GetLoadedLevel = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __OnRep_LevelInstanceSpawnGuid = 0;
	}
}