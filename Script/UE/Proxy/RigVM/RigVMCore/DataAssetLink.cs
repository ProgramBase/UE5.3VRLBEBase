using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.DataAssetLink")]
	public partial class UDataAssetLink : UNameSpacedUserData, IStaticClass
	{
		public UDataAsset DataAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataAsset, __ReturnBuffer);

					return *(UDataAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataAsset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.DataAssetLink");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetDataAsset(UDataAsset InDataAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataAsset, __InBuffer);
			}
		}

		public virtual UDataAsset GetDataAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataAsset, __ReturnBuffer);

				return *(UDataAsset*)__ReturnBuffer;
			}
		}

		private static uint __DataAsset = 0;

		private static uint __SetDataAsset = 0;

		private static uint __GetDataAsset = 0;
	}
}