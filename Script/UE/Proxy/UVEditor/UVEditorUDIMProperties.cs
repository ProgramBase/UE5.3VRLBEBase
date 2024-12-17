using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditorUDIMProperties")]
	public partial class UUVEditorUDIMProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public FString UDIMSourceAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMSourceAsset, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMSourceAsset, __InBuffer);
				}
			}
		}

		public UTexture2D UDIMSourceTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMSourceTexture, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMSourceTexture, __InBuffer);
				}
			}
		}

		public TArray<FUDIMSpecifier> ActiveUDIMs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveUDIMs, __ReturnBuffer);

					return *(TArray<FUDIMSpecifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveUDIMs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditorUDIMProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUDIMsFromTexture()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetUDIMsFromTexture);
			}
		}

		public virtual void SetUDIMsFromAsset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetUDIMsFromAsset);
			}
		}

		public virtual TArray<FString> GetAssetNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAssetNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual int AssetByIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AssetByIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __UDIMSourceAsset = 0;

		private static uint __UDIMSourceTexture = 0;

		private static uint __ActiveUDIMs = 0;

		private static uint __SetUDIMsFromTexture = 0;

		private static uint __SetUDIMsFromAsset = 0;

		private static uint __GetAssetNames = 0;

		private static uint __AssetByIndex = 0;
	}
}