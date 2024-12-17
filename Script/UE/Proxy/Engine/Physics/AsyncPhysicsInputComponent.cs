using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncPhysicsInputComponent")]
	public partial class UAsyncPhysicsInputComponent : UActorComponent, IStaticClass
	{
		public TSubclassOf<UAsyncPhysicsData> DataClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataClass, __ReturnBuffer);

					return *(TSubclassOf<UAsyncPhysicsData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataClass, __InBuffer);
				}
			}
		}

		public TArray<UAsyncPhysicsData> BufferedData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BufferedData, __ReturnBuffer);

					return *(TArray<UAsyncPhysicsData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BufferedData, __InBuffer);
				}
			}
		}

		public UAsyncPhysicsData DataToConsume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataToConsume, __ReturnBuffer);

					return *(UAsyncPhysicsData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataToConsume, __InBuffer);
				}
			}
		}

		public UAsyncPhysicsData DataToWrite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataToWrite, __ReturnBuffer);

					return *(UAsyncPhysicsData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataToWrite, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AsyncPhysicsInputComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ServerRPCBufferInput(UAsyncPhysicsData AsyncPhysicsData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AsyncPhysicsData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerRPCBufferInput, __InBuffer);
			}
		}

		public virtual UAsyncPhysicsData GetDataToWrite()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataToWrite, __ReturnBuffer);

				return *(UAsyncPhysicsData*)__ReturnBuffer;
			}
		}

		public virtual UAsyncPhysicsData GetDataToConsume()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataToConsume, __ReturnBuffer);

				return *(UAsyncPhysicsData*)__ReturnBuffer;
			}
		}

		private static uint __DataClass = 0;

		private static uint __BufferedData = 0;

		private static uint __DataToConsume = 0;

		private static uint __DataToWrite = 0;

		private static uint __ServerRPCBufferInput = 0;

		private static uint __GetDataToWrite = 0;

		private static uint __GetDataToConsume = 0;
	}
}