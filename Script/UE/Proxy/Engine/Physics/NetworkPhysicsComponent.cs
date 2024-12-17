using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetworkPhysicsComponent")]
	public partial class UNetworkPhysicsComponent : UActorComponent, IStaticClass
	{
		public TArray<byte> ReplicatedInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedInputs, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedInputs, __InBuffer);
				}
			}
		}

		public TArray<byte> ReplicatedStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedStates, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedStates, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetworkPhysicsComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ServerReceiveInputsDatas(TArray<byte> ClientInputs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ClientInputs?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerReceiveInputsDatas, __InBuffer);
			}
		}

		public virtual void OnRep_SetReplicatedStates()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_SetReplicatedStates);
			}
		}

		public virtual void OnRep_SetReplicatedInputs()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_SetReplicatedInputs);
			}
		}

		private static uint __ReplicatedInputs = 0;

		private static uint __ReplicatedStates = 0;

		private static uint __ServerReceiveInputsDatas = 0;

		private static uint __OnRep_SetReplicatedStates = 0;

		private static uint __OnRep_SetReplicatedInputs = 0;
	}
}