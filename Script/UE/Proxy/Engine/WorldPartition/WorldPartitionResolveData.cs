using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionResolveData")]
	public partial class FWorldPartitionResolveData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionResolveData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionResolveData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPartitionResolveData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPartitionResolveData A, FWorldPartitionResolveData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionResolveData A, FWorldPartitionResolveData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionResolveData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FActorContainerID ContainerID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ContainerID, __ReturnBuffer);

					return *(FActorContainerID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ContainerID, __InBuffer);
				}
			}
		}

		public FString SourceWorldAssetPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceWorldAssetPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceWorldAssetPath, __InBuffer);
				}
			}
		}

		private static uint __ContainerID = 0;

		private static uint __SourceWorldAssetPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}