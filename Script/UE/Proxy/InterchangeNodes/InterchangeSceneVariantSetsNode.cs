using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeSceneVariantSetsNode")]
	public partial class UInterchangeSceneVariantSetsNode : UInterchangeBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeSceneVariantSetsNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool RemoveCustomVariantSetUid(FString VariantUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariantUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCustomVariantSetUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetCustomVariantSetUids(ref TArray<FString> OutVariantUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutVariantUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCustomVariantSetUids, __InBuffer, __OutBuffer);

				OutVariantUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual int GetCustomVariantSetUidCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCustomVariantSetUidCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetCustomVariantSetUid(int Index, ref FString OutVariantUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutVariantUid?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCustomVariantSetUid, __InBuffer, __OutBuffer);

				OutVariantUid = *(FString*)(__OutBuffer);

			}
		}

		public virtual bool AddCustomVariantSetUid(FString VariantUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariantUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddCustomVariantSetUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __RemoveCustomVariantSetUid = 0;

		private static uint __GetCustomVariantSetUids = 0;

		private static uint __GetCustomVariantSetUidCount = 0;

		private static uint __GetCustomVariantSetUid = 0;

		private static uint __AddCustomVariantSetUid = 0;
	}
}