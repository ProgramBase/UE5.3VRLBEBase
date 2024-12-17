using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.ObjectElementAssetDataInterface")]
	public partial class UObjectElementAssetDataInterface : UObject, IStaticClass, ITypedElementAssetDataInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ObjectElementAssetDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FAssetData GetAssetData(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAssetData, __InBuffer, __ReturnBuffer);

				return *(FAssetData*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// An array of valid asset datas.
		/// </returns>
		public virtual TArray<FAssetData> GetAllReferencedAssetDatas(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAllReferencedAssetDatas, __InBuffer, __ReturnBuffer);

				return *(TArray<FAssetData>*)__ReturnBuffer;
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

		private static uint __GetAssetData = 0;

		private static uint __GetAllReferencedAssetDatas = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}