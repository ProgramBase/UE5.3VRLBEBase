using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkinnedAsset")]
	public partial class USkinnedAsset : UStreamableRenderAsset, IStaticClass, IInterface_AsyncCompilation
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkinnedAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

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

		public virtual USkeletalMeshSocket FindSocketInfo(FName InSocketName, ref FTransform OutTransform, ref int OutBoneIndex, ref int OutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = OutBoneIndex;

				*(int*)(__InBuffer + 20) = OutIndex;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindSocketInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTransform = *(FTransform*)(__OutBuffer);

				OutBoneIndex = *(int*)(__OutBuffer + 8);

				OutIndex = *(int*)(__OutBuffer + 12);

				return *(USkeletalMeshSocket*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMeshSocket FindSocket(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindSocket, __InBuffer, __ReturnBuffer);

				return *(USkeletalMeshSocket*)__ReturnBuffer;
			}
		}

		private static uint __ExecuteUbergraph = 0;

		private static uint __FindSocketInfo = 0;

		private static uint __FindSocket = 0;
	}
}