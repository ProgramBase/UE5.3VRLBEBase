using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundAssetSubsystem")]
	public partial class UMetaSoundAssetSubsystem : UEngineSubsystem, IStaticClass
	{
		public TArray<FMetaSoundAsyncAssetDependencies> LoadingDependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LoadingDependencies, __ReturnBuffer);

					return *(TArray<FMetaSoundAsyncAssetDependencies>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LoadingDependencies, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundAssetSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnregisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Directories?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterAssetClassesInDirectories, __InBuffer);
			}
		}

		public virtual void RegisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Directories?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterAssetClassesInDirectories, __InBuffer);
			}
		}

		private static uint __LoadingDependencies = 0;

		private static uint __UnregisterAssetClassesInDirectories = 0;

		private static uint __RegisterAssetClassesInDirectories = 0;
	}
}