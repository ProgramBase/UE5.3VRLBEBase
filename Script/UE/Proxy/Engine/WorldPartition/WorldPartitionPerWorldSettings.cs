using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionPerWorldSettings")]
	public partial class FWorldPartitionPerWorldSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionPerWorldSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionPerWorldSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPartitionPerWorldSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPartitionPerWorldSettings A, FWorldPartitionPerWorldSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionPerWorldSettings A, FWorldPartitionPerWorldSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionPerWorldSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBox> LoadedEditorRegions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LoadedEditorRegions, __ReturnBuffer);

					return *(TArray<FBox>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LoadedEditorRegions, __InBuffer);
				}
			}
		}

		public TArray<FName> LoadedEditorLocationVolumes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LoadedEditorLocationVolumes, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LoadedEditorLocationVolumes, __InBuffer);
				}
			}
		}

		public TArray<FName> NotLoadedDataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NotLoadedDataLayers, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NotLoadedDataLayers, __InBuffer);
				}
			}
		}

		public TArray<FName> LoadedDataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LoadedDataLayers, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LoadedDataLayers, __InBuffer);
				}
			}
		}

		private static uint __LoadedEditorRegions = 0;

		private static uint __LoadedEditorLocationVolumes = 0;

		private static uint __NotLoadedDataLayers = 0;

		private static uint __LoadedDataLayers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}